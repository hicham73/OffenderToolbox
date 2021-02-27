using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;

namespace MigrationHelper.Modules.Task
{
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        private void BtnBulkDelete_Click(object sender, EventArgs e)
        {

            
            var entities = txtInput.Text.Split('\n');

            //var queries = new List<QueryExpression>();

            foreach (var en in entities)
            {
                txtLog.AppendText($"Bulk deleting entity: {en}");
                //if(!string.IsNullOrEmpty(en))
                //    queries.Add(new QueryExpression(en));

                var bulkDeleteRequest = new BulkDeleteRequest();
                bulkDeleteRequest.JobName = $"Removing all data from {en}";
                var qe = new QueryExpression(en);
                qe.Criteria.AddCondition("CreatedBy", ConditionOperator.Equal, new Guid("7866A909-07A4-E911-A97E-001DD800C973"));

                bulkDeleteRequest.QuerySet = new QueryExpression[] {
                    new QueryExpression(en)
                }; // queries.ToArray<QueryExpression>();
                bulkDeleteRequest.StartDateTime = DateTime.Now.ToUniversalTime();
                bulkDeleteRequest.RecurrencePattern = String.Empty;
                bulkDeleteRequest.SendEmailNotification = false;
                bulkDeleteRequest.ToRecipients = new Guid[] { };
                bulkDeleteRequest.CCRecipients = new Guid[] { };
                var _bulkDeleteResponse = (BulkDeleteResponse)CrmConnManager.LService.Execute(bulkDeleteRequest);
                txtLog.AppendText($"{Environment.NewLine}The bulk delete operation has been requested.");

            }

        }
        private void BtnSetMigEntities_Click(object sender, EventArgs e)
        {
            var entities = txtInput.Text.Split('\n');

            var queries = new List<QueryExpression>();

            App.MigEntities.Clear();

            foreach (var en in entities)
            {
                App.MigEntities.Add(new CrmEntity()
                {
                     LogicalName = en,
                     DisplayName = en,

                });

            }
        }

        private void BtnDeactivateFormulas_Click(object sender, EventArgs e)
        {
            var fetchXml = string.Empty;

            if (string.IsNullOrEmpty(txtInput.Text))
                fetchXml = CrmHelper.GetFormulaFetchForMigrationEntities();
            else
                fetchXml = txtInput.Text;

            var result = CrmConnManager.LService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;

            txtLog.AppendText($"Number of active formulas: {result.Count}");

            int count = 0; ;

            foreach (var en in result)
            {
                if(count++ % 50 == 0)
                    txtLog.AppendText($"Deactivated formulas count: {count}");

                var id = en.Id;

                var entityName = en.GetAttributeValue<string>("north52_sourceentityname");
                var name = en.GetAttributeValue<string>("north52_name");

                var formula = new CrmFormula()
                {
                    ID = id,
                    Name = name,
                    Type = new MigrationHelper.Option()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("north52_formulatype").Value,
                        Name = en.FormattedValues["north52_formulatype"]
                    },
                    StatusCode = new MigrationHelper.Option()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("statuscode").Value,
                        Name = en.FormattedValues["statuscode"]
                    },
                    StateCode = new MigrationHelper.Option()
                    {
                        Value = en.GetAttributeValue<OptionSetValue>("statecode").Value,
                        Name = en.FormattedValues["statecode"]
                    },

                };

                //txtLog.AppendText($"Formula Name: {entityName}:{formula.Name}, Type: {formula.Type.Name} {Environment.NewLine}");


                CrmHelper.DeactivateRecord("north52_formula", formula.ID, CrmConnManager.LService);

            }
        }

        private void BtnActivateFormulas_Click(object sender, EventArgs e)
        {
            var fetchXml = string.Empty;

            if (string.IsNullOrEmpty(txtInput.Text))
                fetchXml = CrmHelper.GetFormulaFetchForMigrationEntities();
            else
                fetchXml = txtInput.Text;

            var result = CrmConnManager.LService.RetrieveMultiple(new FetchExpression(fetchXml)).Entities;

            txtLog.AppendText($"Number of active formulas: {result.Count}");

            int count = 0;

            foreach (var en in result)
            {
                if (count++ % 50 == 0)
                    txtLog.AppendText($"Activated formulas count: {count}");

                var id = en.Id;

                var entityName = en.GetAttributeValue<string>("north52_sourceentityname");
                var name = en.GetAttributeValue<string>("north52_name");

                try
                {
                    CrmHelper.ActivateRecord("north52_formula", id, CrmConnManager.RService);
                }
                catch (Exception ex)
                {   
                    txtLog.AppendText($"**** Exception while activating formula: {name} {Environment.NewLine}");
                    txtLog.AppendText($"**** Message: {ex.Message} {Environment.NewLine}");
                }

            }
        }
    }
}
