using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
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



            return fetchXml;

        }

        public static string GetFormulaFetchForMigrationEntities()
        {
            var values = string.Empty;
            foreach (var en in App.MigEntities)
            {
                values += $"<value>{en.LogicalName}</value>";
            }

            var fetchXml = $@"
                <fetch top='5000'>
                  <entity name='north52_formula'>
                    <attribute name='north52_formulaid' />
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
                      <condition attribute='statecode' operator='eq' value='0' />
                      <condition attribute='north52_formulatype' operator='not-in' >
                        <value>217890014</value>
                        <value>217890015</value>
                      </condition>
                    </filter>
                  </entity>
                </fetch>";

            return fetchXml;

        }

        public static Reference GetReference(Entity e, string attrName)
        {
            Reference r = null;
            EntityReference er = null;

            if (attrName.IndexOf(".") > -1)
                er = e.GetAttributeValue<AliasedValue>(attrName)?.Value as EntityReference;
            else
                er = e.GetAttributeValue<EntityReference>(attrName);

            if (er != null)
                r = new Reference() { Id = er.Id, Name = er.Name };

            return r;
        }

        public static Option GetOption(Entity e, string attrName)
        {
            Option opt = null;

            if (e.FormattedValues.Contains(attrName))
            {
                return new Option()
                {
                    Value = e.GetAttributeValue<OptionSetValue>(attrName)?.Value,
                    Name = e.FormattedValues[attrName]

                };

            }

            return opt;
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

        public static void DeactivateRecord(string entityName, Guid recordId, IOrganizationService organizationService)
        {
                //StateCode = 1 and StatusCode = 2 for deactivating Account or Contact
                SetStateRequest setStateRequest = new SetStateRequest()
                {
                    EntityMoniker = new EntityReference
                    {
                        Id = recordId,
                        LogicalName = entityName,
                    },
                    State = new OptionSetValue(1),
                    Status = new OptionSetValue(2)
                };
                organizationService.Execute(setStateRequest);
        }

        //Activate a record
        public static void ActivateRecord(string entityName, Guid recordId, IOrganizationService organizationService)
        {
            var cols = new ColumnSet(new[] { "statecode", "statuscode" });

            //Check if it is Inactive or not
            var entity = organizationService.Retrieve(entityName, recordId, cols);

            if (entity != null && entity.GetAttributeValue<OptionSetValue>("statecode").Value == 1)
            {
                //StateCode = 0 and StatusCode = 1 for activating Account or Contact
                SetStateRequest setStateRequest = new SetStateRequest()
                {
                    EntityMoniker = new EntityReference
                    {
                        Id = recordId,
                        LogicalName = entityName,
                    },
                    State = new OptionSetValue(0),
                    Status = new OptionSetValue(1)
                };
                organizationService.Execute(setStateRequest);
            }
        }

        public static void SetStatus(IOrganizationService service, string entityName, Guid recordId, int stateCode, int statusCode)
        {
            SetStateRequest setStateRequest = new SetStateRequest()
            {
                EntityMoniker = new EntityReference
                {
                    Id = recordId,
                    LogicalName = entityName,
                },
                State = new OptionSetValue(stateCode),
                Status = new OptionSetValue(statusCode)
            };
            service.Execute(setStateRequest);

        }
    }

    public class Reference
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
    }

    public class Option
    {
        public int? Value { get; set; }
        public string Name { get; set; }
    }
}
