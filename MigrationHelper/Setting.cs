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
        public static string OptionEntitiesValue { get; set; }
        public static string LookupEntitiesValue { get; set; }
        public static string[] MigEntitiesList { get; set; }
        public static string[] LookupEntitiesList { get; set; }

        public static List<MetaEntity> LookupEntities { get; set; } = new List<MetaEntity>();
        public static List<MetaEntity> OptionEntities { get; set; } = new List<MetaEntity>();

        public static void Load()
        {
            ConnString1 = ConfigurationManager.AppSettings["connstring1"];
            ConnString2 = ConfigurationManager.AppSettings["connstring2"];
            OptionEntitiesValue = ConfigurationManager.AppSettings["option-entities"];
            LookupEntitiesValue = ConfigurationManager.AppSettings["lookup-entities"];

            MigEntitiesList  = ConfigurationManager.AppSettings["mig-entities"].Split(',');
            LookupEntitiesList = ConfigurationManager.AppSettings["lookup-entities"].Split(',');

        }

    }
}
