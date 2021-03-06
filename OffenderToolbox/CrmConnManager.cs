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

        static CrmServiceClient m_lclient;
        static CrmServiceClient m_rclient;

        static IOrganizationService m_lservice;
        static IOrganizationService m_rservice;

        public static IOrganizationService LService { get { return m_lservice; } }
        public static IOrganizationService RService { get { return m_rservice; } }

        public static string LOrgName
        {
            get
            {
                return m_lclient.ConnectedOrgFriendlyName;
            }
        }
        public static string ROrgName
        {
            get
            {
                return m_rclient.ConnectedOrgFriendlyName;
            }
        }


        public static bool IsConnected = false;


        public static void Connect()
        {
            LeftConnect();
            RightConnect();
        }
        public static void LeftConnect()
        {
            if (m_lservice != null)
                return;

            m_lclient = new CrmServiceClient(Shared.Setting.ConnString1);
            m_lservice = (IOrganizationService)m_lclient.OrganizationWebProxyClient != null ? (IOrganizationService)m_lclient.OrganizationWebProxyClient : (IOrganizationService)m_lclient.OrganizationServiceProxy;

            MessageBox.Show($"Connected to {m_lclient.ConnectedOrgFriendlyName}");


        }

        public static void RightConnect()
        {
            if (m_rservice != null)
                return;

            m_rclient = new CrmServiceClient(Shared.Setting.ConnString2);

            m_rservice = (IOrganizationService)m_rclient.OrganizationWebProxyClient != null ? (IOrganizationService)m_rclient.OrganizationWebProxyClient : (IOrganizationService)m_rclient.OrganizationServiceProxy;

            MessageBox.Show($"Connected to {m_rclient.ConnectedOrgFriendlyName}");

        }


    }
}
