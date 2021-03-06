using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationHelper.Modules.Formula
{
    public class FormulaManager
    {

        public List<FormulaDiffRecord> FormulaDiffRecords { get; set; }  = new List<FormulaDiffRecord>();
        public List<CrmFormulaEntity> FormulaEntities { get; set; }  = new List<CrmFormulaEntity>();

        public void LoadMeta()
        {
            var qe = new QueryExpression("north52_formula");
            //qe.TopCount = 1000;
            qe.ColumnSet = new ColumnSet(true);

            FormulaDiffRecords.Clear();
            FormulaEntities.Clear();

            var lresult = CrmConnManager.LService.RetrieveMultiple(qe).Entities;
            ProcessResult(lresult, SourceTypes.Left);

            var rresult = CrmConnManager.RService.RetrieveMultiple(qe).Entities;
            ProcessResult(rresult, SourceTypes.Right);

            Compare();

        }

        private void Compare()
        {
            foreach (var en in FormulaEntities)
            {
                var drs = en.FormulaDiffRecords.Where(x => 
                    x.LFormula == null || 
                    x.RFormula == null || 
                    x.LFormula.StateCode?.Value != x.RFormula.StateCode?.Value ||
                    x.LFormula?.Description != x.RFormula?.Description);

                foreach (var dr in drs) 
                {
                    dr.IsDifferent = true;
                }

                if(drs.Count() > 0)
                    en.IsDifferent = true;
            }
        }

        public enum SourceTypes { 
            Left,
            Right
        }

        public void ProcessResult(DataCollection<Entity> result, SourceTypes sourceType) {
            foreach (var en in result)
            {
                var id = en.Id;

                var entityName = en.GetAttributeValue<string>("north52_sourceentityname");
                var formulaName = en.GetAttributeValue<string>("north52_name");

                var formula = new CrmFormula()
                {
                    Id = id,
                    Name = formulaName,
                    //Type = new Option()
                    //{
                    //    Value = en.GetAttributeValue<OptionSetValue>("north52_formulatype").Value,
                    //    Name = en.FormattedValues["north52_formulatype"]
                    //},
                    Type = CrmHelper.GetOption(en,"north52_formulatype"),
                    StatusCode = CrmHelper.GetOption(en, "statuscode"),
                    StateCode = CrmHelper.GetOption(en, "statecode"),
                    SourceEntityName = en.GetAttributeValue<string>("north52_sourceentityname"),
                    SourceEntityProperty = en.GetAttributeValue<string>("north52_sourceentityproperty"),
                    TargetEntityName = en.GetAttributeValue<string>("north52_targetentityname"),
                    TargetEntityproperty = en.GetAttributeValue<string>("north52_targetentityproperty"),
                    Description = en.GetAttributeValue<string>("north52_formuladescription"),

                };


                var dr = FormulaDiffRecords.Where(x => x.Name == formulaName && x.EntityName == entityName).FirstOrDefault();

                if (dr == null)
                {
                    dr = new FormulaDiffRecord()
                    {
                        Name = formulaName,
                        EntityName = entityName,
                    };

                    FormulaDiffRecords.Add(dr);
                }

                if (sourceType == SourceTypes.Left)
                    dr.LFormula = formula;
                else
                    dr.RFormula = formula;

                CrmFormulaEntity crmEntity = FormulaEntities.Where(x => x.LogicalName == entityName).FirstOrDefault();

                if (crmEntity == null)
                {
                    crmEntity = new CrmFormulaEntity()
                    {
                        LogicalName = entityName
                    };

                    FormulaEntities.Add(crmEntity);
                }

                var fdr = crmEntity.FormulaDiffRecords.Where(x => x.Name == formulaName).FirstOrDefault();

                if (fdr == null)
                { 
                    fdr = dr;
                    crmEntity.FormulaDiffRecords.Add(fdr);
                }


            }

        }

        public static void ExportToExcel()
        {

            var visitedAttrs = new List<string>();
            var csvFile = new CSVFile()
            {
                FileName = "Formulas.csv"
            };

            foreach (var en in App.MigEntities)
            {

                foreach (var f in en.Formulas)
                {

                    var bloc = new CSVBloc()
                    {
                        EntityName = f.SourceEntityName,
                        AttributeName = f.SourceEntityName
                    };

                    csvFile.Blocs.Add(bloc);

                    bloc.AddRow(new string[] { f.Name, f.Type.Value + "", f.Type.Name});

                }
            }

            csvFile.Export();

        }

        public void DeployFormula(Guid id, bool exists) {

            try
            {
                var lformula = CrmConnManager.LService.Retrieve("north52_formula", id, new ColumnSet(true));

                var e = new Entity("north52_formula");
                e.Id = lformula.Id;
                foreach (var a in lformula.Attributes)
                {
                    if (a.Key.StartsWith("north52_"))
                    { 
                        e[a.Key] = lformula[a.Key];
                    }
                }

                if (!exists)
                    CrmConnManager.RService.Create(e);
                else
                    CrmConnManager.RService.Update(e);

                int stateCode = (lformula["statecode"] as OptionSetValue).Value;
                int statusCode = (lformula["statuscode"] as OptionSetValue).Value;

                CrmHelper.SetStatus(CrmConnManager.RService, lformula.LogicalName, lformula.Id, stateCode, statusCode);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"FormulaManager:DeployFormula:Exception: {ex.Message}");
            }

        }
    }

}
