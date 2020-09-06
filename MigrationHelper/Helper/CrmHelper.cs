using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper
{
    public class CrmHelper
    {

        //static int[] entityCodes = { 1, 2, 10108, 10389, 10309, 10305, 10263, 10256, 10272, 10075 };
        public static string GetOptionFetch()
        {

            var entityCodes = Setting.Entities.Replace(" ", "").Split(',');

            var values = string.Empty;
            foreach (var code in entityCodes)
            {
                values += $"<value>{code}</value>";
            }
            var fetchXml = $@"
                    <fetch>
                      <entity name='stringmap'>
                        <attribute name='attributevalue' />
                        <attribute name='attributename' />
                        <attribute name='value' />
                        <attribute name='objecttypecodename' />
                        <attribute name='displayorder' />
                        <attribute name='versionnumber' />
                        <attribute name='objecttypecode' />
                        <attribute name='langid' />
                        <attribute name='organizationid' />
                        <attribute name='stringmapid' />
                        <filter>
                          <condition attribute='objecttypecode' operator='in'>
                            {values}
                          </condition>
                        </filter>
                      </entity>
                    </fetch>";

            return fetchXml;

        }

        public static string GetFormulaFetch()
        {
            var values = string.Empty;
            foreach (var en in App.CrmEntities)
            {
                values += $"<value>{en.Name}</value>";
            }

            var fetchData = new
            {
                north52_sourceentityname = "account",
                north52_sourceentityname2 = "tri_booking"
            };
            var fetchXml = $@"
                <fetch top='5000'>
                  <entity name='north52_formula'>
                    <attribute name='statuscode' />
                    <attribute name='north52_targetentityname' />
                    <attribute name='north52_sourceentityname' />
                    <attribute name='statecode' />
                    <attribute name='north52_name' />
                    <attribute name='north52_targetentityproperty' />
                    <attribute name='statuscodename' />
                    <attribute name='north52_formulatype' />
                    <attribute name='north52_formulatypename' />
                    <filter>
                      <condition attribute='north52_sourceentityname' operator='in'>
                            {values}
                      </condition>
                    </filter>
                  </entity>
                </fetch>";

            return fetchXml;

        }
    }
}
