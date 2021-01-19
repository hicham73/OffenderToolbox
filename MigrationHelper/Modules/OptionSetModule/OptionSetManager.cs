using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MigrationHelper.Manager
{
    public static class OptionSetManager
    {
        public static void LoadMeta()
        {
            var lResult = GetStringMapData(CrmConnManager.LService).Entities;
            var rResult = GetStringMapData(CrmConnManager.RService).Entities;

            foreach (var en in lResult)
            {
                var entityName = en.GetAttributeValue<string>("objecttypecode");
                var attributeName = en.GetAttributeValue<string>("attributename");
                int optionValue = en.GetAttributeValue<int>("attributevalue");
                var optionName = en.GetAttributeValue<string>("value");

                var crmEntity = App.AllEntities.Where(x => x.LogicalName == entityName).FirstOrDefault();
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

        public static EntityCollection GetStringMapData(IOrganizationService service)
        {
            EntityCollection ec = new EntityCollection();

            EntityCollection rs;

            int pageNum = 1;
            string pagingCookie = "";
            do
            {
                if (pagingCookie != null && pagingCookie != "")
                    pagingCookie = pagingCookie.Replace("\"", "'").Replace(">", "&gt;").Replace("<", "&lt;");

                var fetchXml = CrmHelper.GetOptionFetch(pageNum,pagingCookie);
                rs = service.RetrieveMultiple(new FetchExpression(fetchXml));
                ec.Entities.AddRange(rs.Entities);
                pagingCookie = rs.PagingCookie;
                pageNum++;


            }
            while (rs.MoreRecords && pageNum < 20);

            MessageBox.Show($"Last Page: {pageNum} Total number of records: {ec.Entities.Count}");
            
            return ec;

        }

        internal static void GetUsage()
        {
            foreach (var en in App.AllEntities)
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

        public static void ExportToExcel()
        {

            var visitedAttrs = new List<string>();
            var csvFile = new CSVFile()
            {
                FileName = "OptionsReport.csv"
            };

            foreach (var en in App.MigEntities)
            {
                foreach (var attr in en.OptionAttributes)
                {

                    var visitedBloc = csvFile.Blocs.Where(b => b.AttributeName == attr.Name).FirstOrDefault();

                    if (visitedBloc != null)
                    { 
                        visitedBloc.EntityName += "," + en.LogicalName;
                        continue;
                    }

                    var bloc = new CSVBloc()
                    {
                        EntityName = en.LogicalName,
                        AttributeName = attr.Name
                    };

                    csvFile.Blocs.Add(bloc);

                    if (attr.LeftOnlyOptions.Count > 0 || attr.RightOnlyOptions.Count > 0)
                    {

                        if (attr.CommonOptions.Count == 2 && (attr.CommonOptions[0].Name == "Yes" || attr.CommonOptions[0].Name == "No"))
                            continue;

                        if (attr.Name == "statecode" || attr.Name == "statuscode")
                            continue;

                        foreach (var o in attr.CommonOptions)
                        {
                            bloc.AddRow(new string[] { o.Value.ToString(), o.Name, o.Value.ToString(), o.Name, o.Usage?"Yes":"No", o.AllUsage?"Yes":"No", o.AllUsageEntities });
                        }
                        foreach (var o in attr.LeftOnlyOptions)
                        {
                            bloc.AddRow(new string[] { o.Value.ToString(), o.Name, "", "", o.Usage ? "Yes" : "No", o.AllUsage ? "Yes" : "No", o.AllUsageEntities });
                        }
                        foreach (var o in attr.RightOnlyOptions)
                        {
                            bloc.AddRow(new string[] { "", "", o.Value.ToString(), o.Name, o.Usage ? "Yes" : "No", o.AllUsage ? "Yes" : "No", o.AllUsageEntities });
                        }
                    }

                }
            }

            csvFile.Export();





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
    }
}
