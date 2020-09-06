using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using MigrationHelper.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationHelper
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            Setting.Load();

        }

        private void BtnLoadOptions_Click(object sender, EventArgs e)
        {
            CrmConnManager.Connect();

            OptionSetManager.LoadMeta();

            OptionSetManager.Compare();

            DisplayOptionTree();

        }

        private void DisplayOptionTree()
        {

            tvEntities.Nodes.Clear();

            foreach (var ce in App.CrmEntities)
            {
                var node = new TreeNode(ce.Name);
                tvEntities.Nodes.Add(node);
                foreach (var ca in ce.Attributes)
                {
                    var an = new TreeNode(ca.Name);
                    if (ca.LeftOnlyOptions.Count > 0 || ca.RightOnlyOptions.Count > 0)
                    {
                        an.BackColor = Color.Red;
                        an.ForeColor = Color.White;
                    }

                    an.Tag = ca;
                    node.Nodes.Add(an);
                }
            }
        }

        private void DisplayFormulaTree()
        {

            tvFormulaEntities.Nodes.Clear();

            foreach (var ce in App.CrmEntities)
            {
                var node = new TreeNode(ce.Name);
                node.Tag = ce;
                tvFormulaEntities.Nodes.Add(node);
            }
        }

        public void DisplayOptions(List<CrmOption> list, Color bgColor, Color fgColor)
        {
            foreach (var o in list)
            {
                ListViewItem item = new ListViewItem(o.Value.ToString());
                item.SubItems.Add(o.Name);
                item.BackColor = bgColor;
                item.ForeColor = fgColor;
                lvCompareResult.Items.Add(item);
            }
        }

        private void tvEntities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;

            if (node.Tag == null)
                return;

            var ca = (CrmAttribute)node.Tag;
            
            lvCompareResult.Items.Clear();

            DisplayOptions(ca.CommonOptions, Color.White, Color.Black);
            DisplayOptions(ca.LeftOnlyOptions, Color.White, Color.Green);
            DisplayOptions(ca.RightOnlyOptions, Color.White, Color.Blue);

           
            lvCompareResult.Refresh();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            OptionSetManager.LoadMeta();

            OptionSetManager.Compare();

            DisplayOptionTree();
        }


        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            OptionSetManager.ExportToExcel();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            CrmConnManager.Connect();

            MessageBox.Show("Connected successfully!");
        }

        private void BtnLoadFormulas_Click(object sender, EventArgs e)
        {
            FormulaManager.LoadMeta();

            DisplayFormulaTree();
        }

        private void tvFormulaEntities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;

            if (node.Tag == null)
                return;

            var ce = (CrmEntity)node.Tag;

            DisplayFormulas(ce);
        }

        private void DisplayFormulas(CrmEntity crmEntity)
        {
            dataGridFormula.Rows.Clear();
            foreach (var formula in crmEntity.Formulas)
            {
                dataGridFormula.Rows.Add(false, formula.Name, formula.Type.Name, "3", "4", formula.StateCode.Name, formula.StatusCode.Name);
            }

        }
    }
}
