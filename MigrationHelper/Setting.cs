using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public static class Setting
    {
        public static string ConnString1 { get; set; }
        public static string ConnString2 { get; set; }
        public static string Entities { get; set; }

        public static void Load()
        {
            ConnString1 = ConfigurationManager.AppSettings["connstring1"];
            ConnString2 = ConfigurationManager.AppSettings["connstring3"];
            Entities = ConfigurationManager.AppSettings["entities"];
        }

    }
}
