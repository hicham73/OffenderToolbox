using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper.Manager
{
    public static class OptionSetManager
    {
        public static void LoadMeta()
        {

            var fetchXml = CrmHelper.GetOptionFetch();

            var lResult = CrmConnManager.LService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;
            var rResult = CrmConnManager.RService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;


            foreach (var en in lResult)
            {
                var entityName = en.GetAttributeValue<string>("objecttypecode");
                var attributeName = en.GetAttributeValue<string>("attributename");
                int optionValue = en.GetAttributeValue<int>("attributevalue");
                var optionName = en.GetAttributeValue<string>("value");

                var crmEntity = App.MigEntities.Where(x => x.LogicalName == entityName).FirstOrDefault();
                if (crmEntity == null)
                {
                    crmEntity = new CrmEntity()
                    {
                        LogicalName = entityName
                    };

                    App.MigEntities.Add(crmEntity);
                }


                var crmAttribute = crmEntity.OptionAttributes.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmAttribute == null)
                {
                    crmAttribute = new CrmOptionAttribute()
                    {
                        Name = attributeName
                    };

                    crmEntity.OptionAttributes.Add(crmAttribute);
                }

                var crmOption = crmAttribute.LOptions.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmOption == null)
                {
                    crmOption = new CrmOption()
                    {
                        Name = optionName,
                        Value = optionValue


                    };

                    crmAttribute.LOptions.Add(crmOption);
                }

            }

            foreach (var en in rResult)
            {
                var entityName = en.GetAttributeValue<string>("objecttypecode");
                var attributeName = en.GetAttributeValue<string>("attributename");
                int optionValue = en.GetAttributeValue<int>("attributevalue");
                var optionName = en.GetAttributeValue<string>("value");

                var crmEntity = App.MigEntities.Where(x => x.LogicalName == entityName).FirstOrDefault();
                if (crmEntity == null)
                {
                    crmEntity = new CrmEntity()
                    {
                        LogicalName = entityName
                    };

                    App.MigEntities.Add(crmEntity);
                }


                var crmAttribute = crmEntity.OptionAttributes.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmAttribute == null)
                {
                    crmAttribute = new CrmOptionAttribute()
                    {
                        Name = attributeName
                    };

                    crmEntity.OptionAttributes.Add(crmAttribute);
                }

                var crmOption = crmAttribute.ROptions.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmOption == null)
                {
                    crmOption = new CrmOption()
                    {
                        Name = optionName,
                        Value = optionValue

                    };

                    crmAttribute.ROptions.Add(crmOption);
                }

            }
        }

        internal static void GetUsage()
        {
            foreach (var en in App.MigEntities)
            {
                foreach (var attr in en.OptionAttributes)
                {
                    if (attr.LeftOnlyOptions.Count > 0)
                    {
                        foreach (var o in attr.LOptions)
                        {
                            o.Usage = CrmHelper.IsOptionValueUsed(en.LogicalName, attr.Name, o.Value);
                        }
                    }
                }
            }
            foreach (var en in App.MigEntities)
            {
                foreach (var attr in en.OptionAttributes)
                {
                    if (attr.LeftOnlyOptions.Count > 0)
                    {
                        foreach (var o in attr.LOptions)
                        {
                            foreach (var ue in App.MigEntities.Where(ce => ce.OptionAttributes.Where(at => at.Name == attr.Name && at.LOptions.Where(op => op.Name == o.Name && op.Usage).Any()).Any()))
                            {
                                o.AllUsageEntities += $"- {ue.LogicalName}";
                            }
                            o.AllUsage = !string.IsNullOrEmpty(o.AllUsageEntities);
                        }

                    }
                }
            }
        }

        internal static void ExportToExcel()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"OptionsReport.csv"))
            {
                foreach (var en in App.MigEntities)
                {
                    file.WriteLine($"{en.LogicalName},,,,");
                    foreach (var attr in en.OptionAttributes)
                    {
                        if (attr.LeftOnlyOptions.Count > 0 || attr.RightOnlyOptions.Count > 0)
                        {
                            file.WriteLine($"{attr.Name},,,,");
                            foreach (var o in attr.CommonOptions)
                            {
                                file.WriteLine($"{o.Value},{o.Name},{o.Value},{o.Name},");
                            }
                            foreach (var o in attr.LeftOnlyOptions)
                            {
                                file.WriteLine($"{o.Value},{o.Name},,,");
                            }
                            foreach (var o in attr.RightOnlyOptions)
                            {
                                file.WriteLine($",,{o.Value},{o.Name},");
                            }
                        }
                    }
                }
            }
        }

        internal static void Compare()
        {
            foreach (var ce in App.MigEntities)
            {
                foreach (var ca in ce.OptionAttributes)
                {
                    ca.CommonOptions = ca.LOptions.Where(lo => ca.ROptions.Where(ro => ro.Value == lo.Value && ro.Name == lo.Name).Any()).ToList();
                    ca.LeftOnlyOptions = ca.LOptions.Where(lo => !ca.ROptions.Where(ro => ro.Value == lo.Value && ro.Name == lo.Name).Any()).ToList();
                    ca.RightOnlyOptions = ca.ROptions.Where(ro => !ca.LOptions.Where(lo => lo.Value == ro.Value && lo.Name == ro.Name).Any()).ToList();
                }
            }

        }

        static void LoadLookups()
        {
            var entityRequest = new RetrieveAllEntitiesRequest
            {
                RetrieveAsIfPublished = true,
                EntityFilters = EntityFilters.Entity | EntityFilters.Attributes | EntityFilters.Relationships
            };

            var entityResponse = (RetrieveAllEntitiesResponse)CrmConnManager.LService.Execute(entityRequest);

            Console.WriteLine("====== Searching For Targetless Lookups ");
            foreach (var ent in entityResponse.EntityMetadata)
            {
                foreach (var field in ent.Attributes
                    .OfType<LookupAttributeMetadata>()
                    .Where(lookup => !lookup.Targets.Any()))
                {
                }
            }

        }
    }
}
