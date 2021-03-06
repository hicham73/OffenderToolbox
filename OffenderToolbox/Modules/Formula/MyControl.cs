using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigrationHelper.Shared;

namespace MigrationHelper.Modules.Formula
{
    public partial class MyControl : UserControl
    {

        FormulaManager mgr;
        FormulaDiffRecord SelectedDiffRecord;

        public MyControl()
        {
            InitializeComponent();
            mgr = new FormulaManager();
        }

        private void DisplayFormulaTree()
        {

            tvFormulaEntities.Nodes.Clear();

            foreach (var ce in mgr.FormulaEntities)
            {
                var node = new TreeNode(ce.LogicalName);
                node.Tag = ce;
                tvFormulaEntities.Nodes.Add(node);

                if (ce.IsDifferent)
                    node.BackColor = Color.Pink;
            }
        }


        private void BtnLoadFormulas_Click(object sender, EventArgs e)
        {
            lblLeftOrgName.Text = CrmConnManager.LOrgName;
            lblRightOrgName.Text = CrmConnManager.ROrgName;

            mgr.LoadMeta();

            DisplayFormulaTree();
        }

        private void TvEntities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;

            if (node.Tag == null)
                return;

            var ce = (CrmFormulaEntity)node.Tag;

            DisplayFormulas(ce);
        }

        private void DisplayFormulas(CrmFormulaEntity crmEntity)
        {
            dataGridFormula.Rows.Clear();
            foreach (var dr in crmEntity.FormulaDiffRecords)
            {
                var idx = dataGridFormula.Rows.Add();

                var row = dataGridFormula.Rows[idx];

                row.Tag = dr;

                row.Cells[0].Value = false;
                row.Cells[1].Value = dr.Name;
                row.Cells[2].Value = dr.LFormula?.Type?.Name;
                row.Cells[3].Value = dr.LFormula?.SourceEntityName;
                row.Cells[4].Value = dr.LFormula?.SourceEntityProperty;
                row.Cells[5].Value = dr.LFormula?.StatusCode.Name;
                row.Cells[6].Value = dr.RFormula?.StatusCode.Name;

                if (dr.IsDifferent)
                    row.DefaultCellStyle.BackColor = Color.Pink;

            }

        }
        private void DisplayFormulasFromSearch(string searchText)
        {
            dataGridFormula.Rows.Clear();
            var drs = mgr.FormulaDiffRecords.Where(x => x.Name.ToLower().Contains(searchText.ToLower()));
            foreach (var dr in drs)
            {
                var idx = dataGridFormula.Rows.Add();

                var row = dataGridFormula.Rows[idx];

                row.Tag = dr;

                row.Cells[0].Value = false;
                row.Cells[1].Value = dr.Name;
                row.Cells[2].Value = dr.LFormula?.Type?.Name;
                row.Cells[3].Value = dr.LFormula?.SourceEntityName;
                row.Cells[4].Value = dr.LFormula?.SourceEntityProperty;
                row.Cells[5].Value = dr.LFormula?.StatusCode.Name;
                row.Cells[6].Value = dr.RFormula?.StatusCode.Name;

                if (dr.IsDifferent)
                    row.DefaultCellStyle.BackColor = Color.Pink;

            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaManager.ExportToExcel();
        }

        private void dataGridFormula_SelectionChanged(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;
            var rows = dgv.SelectedRows;

            if (rows.Count > 0)
            {
                SelectedDiffRecord = (FormulaDiffRecord)rows[0].Tag;
                if (SelectedDiffRecord != null)
                {
                    txtLeftFormula.Text = SelectedDiffRecord.LFormula?.Description;
                    txtRightFormula.Text = SelectedDiffRecord.RFormula?.Description;
                }
            }


        }

        private void BtnOpenInBrowser_Click(object sender, EventArgs e)
        {

            if (SelectedDiffRecord != null)
            {
                var hostname = Shared.Setting.ConnString1.Split(';')[0].Split('=')[1];
                var id = SelectedDiffRecord.LFormula?.Id;

                if (id != null)
                {
                    var url1 = $"{hostname}/main.aspx?pagetype=entityrecord&etn=north52_formula&id={id}";
                    App.OpenUrl(url1);
                }

                hostname = Shared.Setting.ConnString2.Split(';')[0].Split('=')[1];
                id = SelectedDiffRecord.RFormula?.Id;
                if (id != null)
                {
                    var url1 = $"{hostname}/main.aspx?pagetype=entityrecord&etn=north52_formula&id={id}";
                    App.OpenUrl(url1);
                }
            } 
            else
            {
                MessageBox.Show("Please select a formula");
            }


        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    DisplayFormulasFromSearch(txtSearch.Text);
            }
        }

        private void BtnDeploy_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridFormula.Rows)
            {
                if (row.Tag != null) {
                    var record = (FormulaDiffRecord)row.Tag;
                    if ((bool)row.Cells[0].Value && record.LFormula != null)
                    {
                        mgr.DeployFormula(record.LFormula.Id, record.RFormula != null);
                    }
                }
            }
        }

        private void BtnDeactivateFormulas_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            int count = 0;
            foreach (var f in mgr.FormulaDiffRecords) 
            {
                if (f.RFormula != null)
                {
                    var ff = f.RFormula;
                    if (!ff.Type.Name.StartsWith("Client") && ff.StateCode.Value == 0)
                    {
                        CrmHelper.DeactivateRecord("north52_formula", ff.Id, CrmConnManager.RService);
                    }
                }

            }

            MessageBox.Show(sb.ToString());
        }
    }
}
