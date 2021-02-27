using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using MigrationHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaProcessHelper
{
    class Program
    {
        public static IOrganizationService GetOrganizationServiceClientSecret(string clientId, string clientSecret, string organizationUri)
        {
            try
            {
                var conn = new CrmServiceClient($@"AuthType=ClientSecret;url={organizationUri};ClientId={clientId};ClientSecret={clientSecret}");

                return conn.OrganizationWebProxyClient != null ? conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while connecting to CRM " + ex.Message);
                Console.ReadKey();
                return null;
            }
        }

        static void Main(string[] args)
        {


            IOrganizationService orgService = GetOrganizationServiceClientSecret(
                             "6eed9ff6-9e0e-4d4b-95d8-8c500785eb7a",
                             "qR_xr8e3m6BkT38tL-9O~_A~CbcMqekM44",
                             "https://fluoncall-sandbox.crm.dynamics.com");

            var response = orgService.Execute(new WhoAmIRequest());

            //DeltaDelete();

        }

        private static void DeltaDelete()
        {
            CrmConnManager.Connect();

            var con = "Server=KCITSV0PPPJMI02;Database=JMSStaging;Trusted_Connection=True;Connection Timeout=180";

            using (SqlConnection myConnection = new SqlConnection(con))
            {

                myConnection.Open();

                var entities = new List<CrmEntity>();

                var query = $"select * from common.deltaentities";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        var vn = oReader["JMSView"].ToString();
                        var en = oReader["EntityName"].ToString();
                        var pan = $"{en}id";

                        var e = new CrmEntity()
                        {
                            EntityName = en,
                            PrimaryAttributeName = pan,
                            JMSView = vn
                        };

                        entities.Add(e);

                    }
                }

                var sb = new StringBuilder();

                foreach (var en in entities)
                {
                    if (en.EntityName != "tri_offendercontact")
                    {
                        query = $"Select {en.PrimaryAttributeName} from {en.JMSView}";
                        cmd = new SqlCommand(query, myConnection);
                        cmd.CommandTimeout = 180;
                        try
                        {
                            using (SqlDataReader oReader = cmd.ExecuteReader())
                            {
                                while (oReader.Read())
                                {
                                    var jmsid = oReader[en.PrimaryAttributeName].ToString();

                                    en.PartialDeleteList.Add(jmsid);

                                    //Console.WriteLine($"JMSId: {jmsid}");
                                }
                            }

                            var count = en.RetrieveRecords(CrmConnManager.Service);
                            Console.WriteLine($"JMSViewname: {en.JMSView}, DestEntityName: {en.EntityName}, PrimaryAttrName: {en.PrimaryAttributeName} - Count: {count}");
                            en.DeleteRecords(CrmConnManager.Service);

                        }
                        catch (Exception ex)
                        {
                            sb.Append($"query: {query}, exception: {ex.Message}{Environment.NewLine}");
                        }

                    }

                }

                Console.WriteLine("Errors ==================================================================================");
                Console.WriteLine(sb.ToString());
                Console.ReadKey();

                myConnection.Close();
            }
        }
    }
}
