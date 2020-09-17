using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigrationHelper.Manager;

namespace MigrationHelper
{
    public partial class FormulaControl : UserControl
    {
        public FormulaControl()
        {
            InitializeComponent();
        }

        private void DisplayFormulaTree()
        {

            tvFormulaEntities.Nodes.Clear();

            foreach (var ce in App.MigEntities)
            {
                var node = new TreeNode(ce.LogicalName);
                node.Tag = ce;
                tvFormulaEntities.Nodes.Add(node);
            }
        }


        private void BtnLoadFormulas_Click(object sender, EventArgs e)
        {
            FormulaManager.LoadMeta();

            DisplayFormulaTree();
        }

        private void TvEntities_AfterSelect(object sender, TreeViewEventArgs e)
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
