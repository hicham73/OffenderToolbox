using Microsoft.Xrm.Sdk.Query;
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
        public static string GetOptionFetch(int pageNum, string pagingCookie)
        {

            var fetchXml = $@"
                    <fetch page=""{pageNum}"" paging-cookie=""{pagingCookie}"">
  <entity name=""stringmap"" >
    <attribute name=""attributevalue"" />
    <attribute name=""attributename"" />
    <attribute name=""value"" />
    <attribute name=""objecttypecodename"" />
    <attribute name=""displayorder"" />
    <attribute name=""versionnumber"" />
    <attribute name=""objecttypecode"" />
    <attribute name=""langid"" />
    <attribute name=""organizationid"" />
    <attribute name=""stringmapid"" />
    <filter type=""and"" >
      <condition attribute=""attributename"" operator=""not-in"" >
        <value>statecode</value>
        <value>statuscode</value>
      </condition>
      <filter type=""or"">
        <condition attribute=""attributename"" operator=""begins-with"" value=""tri_""/>
        <condition attribute=""attributename"" operator=""begins-with"" value=""kc_""/>
      </filter>
      <filter type=""or"">
        <condition attribute=""objecttypecode"" operator=""gt"" value=""9999"" />
        <condition attribute=""objecttypecode"" operator=""in"" >
          <value>1</value>
          <value>2</value>
          <value>8</value>
        </condition>
      </filter>
    </filter>
  </entity>
</fetch>";

            //var entityCodes = Setting.OptionEntitiesValue.Replace(" ", "").Split(',');

            //var entityCodes = App.MigEntities.Select(x => x.Code).ToArray<int>();

            //var values = string.Empty;
            //foreach (var code in entityCodes)
            //{
            //    values += $"<value>{code}</value>";
            //}
            //var fetchXml = $@"
            //        <fetch>
            //          <entity name='stringmap'>
            //            <attribute name='attributevalue' />
            //            <attribute name='attributename' />
            //            <attribute name='value' />
            //            <attribute name='objecttypecodename' />
            //            <attribute name='displayorder' />
            //            <attribute name='versionnumber' />
            //            <attribute name='objecttypecode' />
            //            <attribute name='langid' />
            //            <attribute name='organizationid' />
            //            <attribute name='stringmapid' />
            //            <filter>
            //              <condition attribute='objecttypecode' operator='in'>
            //                {values}
            //              </condition>
            //              <condition attribute='attributename' operator='not-in'>
            //                <value>statecode</value>
            //                <value>statuscode</value>
            //              </condition>
            //            </filter>
            //          </entity>
            //        </fetch>";

            return fetchXml;

        }

        public static string GetFormulaFetch()
        {
            var values = string.Empty;
            foreach (var en in App.MigEntities)
            {
                values += $"<value>{en.LogicalName}</value>";
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


        public static bool IsOptionValueUsed(string entityName, string attributeName, int optionValue)
        {
            var qa = new QueryByAttribute(entityName);

            qa.ColumnSet = new ColumnSet(false);
            qa.TopCount = 1;
            qa.AddAttributeValue(attributeName, optionValue);

            try
            {
                var entities = CrmConnManager.LService.RetrieveMultiple(qa).Entities;
                if (entities.Count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return true;
            }

            
            return false;
        }
    }
}
