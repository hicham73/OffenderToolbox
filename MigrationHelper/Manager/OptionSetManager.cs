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

            App.CrmEntities.Clear();

            var fetchXml = CrmHelper.GetOptionFetch();

            var lResult = CrmConnManager.LService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;
            var rResult = CrmConnManager.RService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;


            foreach (var en in lResult)
            {
                var entityName = en.GetAttributeValue<string>("objecttypecode");
                var attributeName = en.GetAttributeValue<string>("attributename");
                int optionValue = en.GetAttributeValue<int>("attributevalue");
                var optionName = en.GetAttributeValue<string>("value");

                var crmEntity = App.CrmEntities.Where(x => x.Name == entityName).FirstOrDefault();
                if (crmEntity == null)
                {
                    crmEntity = new CrmEntity()
                    {
                        Name = entityName
                    };

                    App.CrmEntities.Add(crmEntity);
                }


                var crmAttribute = crmEntity.Attributes.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmAttribute == null)
                {
                    crmAttribute = new CrmAttribute()
                    {
                        Name = attributeName
                    };

                    crmEntity.Attributes.Add(crmAttribute);
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

                var crmEntity = App.CrmEntities.Where(x => x.Name == entityName).FirstOrDefault();
                if (crmEntity == null)
                {
                    crmEntity = new CrmEntity()
                    {
                        Name = entityName
                    };

                    App.CrmEntities.Add(crmEntity);
                }


                var crmAttribute = crmEntity.Attributes.Where(x => x.Name == attributeName).FirstOrDefault();
                if (crmAttribute == null)
                {
                    crmAttribute = new CrmAttribute()
                    {
                        Name = attributeName
                    };

                    crmEntity.Attributes.Add(crmAttribute);
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

        internal static void ExportToExcel()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"OptionsReport.csv"))
            {
                foreach (var en in App.CrmEntities)
                {
                    file.WriteLine($"{en.Name},,,,");
                    foreach (var attr in en.Attributes)
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
            foreach (var ce in App.CrmEntities)
            {
                foreach (var ca in ce.Attributes)
                {
                    ca.CommonOptions = ca.LOptions.Where(lo => ca.ROptions.Where(ro => ro.Value == lo.Value && ro.Name == lo.Name).Any()).ToList();
                    ca.LeftOnlyOptions = ca.LOptions.Where(lo => !ca.ROptions.Where(ro => ro.Value == lo.Value && ro.Name == lo.Name).Any()).ToList();
                    ca.RightOnlyOptions = ca.ROptions.Where(ro => !ca.LOptions.Where(lo => lo.Value == ro.Value && lo.Name == ro.Name).Any()).ToList();
                }
            }

        }
    }
}
