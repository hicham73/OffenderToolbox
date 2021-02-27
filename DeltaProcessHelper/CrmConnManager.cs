using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MigrationHelper
{
    class CrmConnManager
    {
        static CrmServiceClient m_client;

        static string connstr = @"Url=https://kc-jms-test.crm9.dynamics.com;authtype=Office365;username=n-hwahbi@kingcounty.gov;password=Juliku100!;RequireNewInstance=true";

        static IOrganizationService m_service;

        public static IOrganizationService Service { get { return m_service; } }

        public static bool IsConnected = false;


        public static void Connect()
        {
            if (m_service != null)
                return;

            m_client = new CrmServiceClient(connstr);
            m_service = (IOrganizationService)m_client.OrganizationWebProxyClient != null ? (IOrganizationService)m_client.OrganizationWebProxyClient : (IOrganizationService)m_client.OrganizationServiceProxy;

        }

    }
}
