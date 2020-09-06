using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{


    class CrmConnManager
    {
        static CrmServiceClient m_lclient;
        static CrmServiceClient m_rclient;

        static IOrganizationService m_lservice;
        static IOrganizationService m_rservice;

        public static IOrganizationService LService { get { return m_lservice; } }
        public static IOrganizationService RService { get { return m_rservice; } }

        public static bool IsConnected = false;


        public static void Connect()
        {
            if (m_lservice != null && m_rservice != null)
                return;

            m_lclient = new CrmServiceClient(@"Url=https://jms.crm9.dynamics.com;authtype=Office365;username=n-hwahbi@kingcounty.gov;password=Juliku88!");
            m_rclient = new CrmServiceClient(@"Url=https://kc-jms-dev.crm9.dynamics.com;authtype=Office365;username=n-hwahbi@kingcounty.gov;password=Juliku88!;RequireNewInstance=true");

            m_lservice = (IOrganizationService)m_lclient.OrganizationWebProxyClient != null ? (IOrganizationService)m_lclient.OrganizationWebProxyClient : (IOrganizationService)m_lclient.OrganizationServiceProxy;
            m_rservice = (IOrganizationService)m_rclient.OrganizationWebProxyClient != null ? (IOrganizationService)m_rclient.OrganizationWebProxyClient : (IOrganizationService)m_rclient.OrganizationServiceProxy;



        }


    }
}
