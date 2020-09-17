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
    public partial class OptionSetControl : UserControl
    {
        public OptionSetControl()
        {
            InitializeComponent();
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

            foreach (var ce in App.MigEntities)
            {
                var node = new TreeNode(ce.LogicalName);
                tvEntities.Nodes.Add(node);
                foreach (var ca in ce.OptionAttributes)
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


        public void DisplayOptions(List<CrmOption> list, Color bgColor, Color fgColor)
        {
            foreach (var o in list)
            {
                ListViewItem item = new ListViewItem(o.Value.ToString());
                item.SubItems.Add(o.Name);
                item.SubItems.Add(o.Usage ? "Yes" : "No");
                item.SubItems.Add(o.AllUsage ? "Yes" : "No");
                item.SubItems.Add(o.AllUsageEntities);
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

            var ca = (CrmOptionAttribute)node.Tag;

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

        private void BtnGetOptionUsage_Click(object sender, EventArgs e)
        {
            OptionSetManager.GetUsage();
        }
    }
}
