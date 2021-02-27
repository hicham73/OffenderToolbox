using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MigrationHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaProcessHelper
{
    public class CrmEntity
    {
        public string JMSView { get; set; }

        public string PrimaryAttributeName { get; set; }

        public string EntityName { get; set; }

        public List<string> PartialDeleteList { get; set; } = new List<string>();


        public void DeleteRecords(IOrganizationService service)
        {
            if (PartialDeleteList.Count() > 0)
            {
                var dateStamp = DateTime.Now.ToString("MM-dd hh:mm");
                var deleteRequest = new BulkDeleteRequest();
                deleteRequest.JobName = $"[{dateStamp}] Delta Process - Delete {PartialDeleteList.Count()} {EntityName}";

                var qe = new QueryExpression(EntityName);
                //qe.Criteria.AddCondition("CreatedBy", ConditionOperator.Equal, new Guid("7866A909-07A4-E911-A97E-001DD800C973"));
                var guids = PartialDeleteList.ToArray();
                qe.Criteria.AddCondition(PrimaryAttributeName, ConditionOperator.In, guids);
                deleteRequest.QuerySet = new QueryExpression[] { qe };

                deleteRequest.StartDateTime = DateTime.Now.ToUniversalTime();
                deleteRequest.RecurrencePattern = String.Empty;
                deleteRequest.SendEmailNotification = false;
                deleteRequest.ToRecipients = new Guid[] { };
                deleteRequest.CCRecipients = new Guid[] { };

                if (guids.Length > 0)
                {
                    var _bulkDeleteResponse = (BulkDeleteResponse)service.Execute(deleteRequest);
                    Console.WriteLine($"Requested job: {deleteRequest.JobName}");
                }
            }
        }

        public int RetrieveRecords(IOrganizationService service)
        {
            if (PartialDeleteList.Count() > 0)
            {
                var qe = new QueryExpression(EntityName);
                //qe.Criteria.AddCondition("CreatedBy", ConditionOperator.Equal, new Guid("7866A909-07A4-E911-A97E-001DD800C973"));
                var guids = PartialDeleteList.ToArray();
                qe.Criteria.AddCondition(PrimaryAttributeName, ConditionOperator.In, guids);

                return service.RetrieveMultiple(qe).Entities.Count;
            }

            return 0;
        }
    }
}
