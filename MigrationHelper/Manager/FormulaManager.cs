using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationHelper.Manager
{
    public static class FormulaManager
    {
        public static void LoadMeta()
        {
            var fetchXml = CrmHelper.GetFormulaFetch();

            var result = CrmConnManager.LService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;

            foreach (var en in result)
            {
                var entityName = en.GetAttributeValue<string>("north52_sourceentityname");
                var name = en.GetAttributeValue<string>("north52_name");

                var formula = new CrmFormula()
                {
                    Name = name,
                    Type = new ValueName()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("north52_formulatype").Value,
                        Name = en.FormattedValues["north52_formulatype"]
                    },
                    StatusCode = new ValueName()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("statuscode").Value,
                        Name = en.FormattedValues["statuscode"]
                    },
                    StateCode = new ValueName()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("statecode").Value,
                        Name = en.FormattedValues["statecode"]
                    },

                };
                

                var crmEntity = App.CrmEntities.Where(x => x.Name == entityName).FirstOrDefault();
                if (crmEntity == null)
                {
                    crmEntity = new CrmEntity()
                    {
                        Name = entityName,

                    };

                    App.CrmEntities.Add(crmEntity);
                }

                crmEntity.Formulas.Add(formula);

                
            }

        }
    }
}
