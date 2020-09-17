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

namespace MigrationHelper.Modules.OptionSetModule
{
    public partial class LookupControl : UserControl
    {
        public LookupControl()
        {
            InitializeComponent();
        }

        private void DisplayLookupTree()
        {

            TVEntityLookup.Nodes.Clear();

            foreach (var en in App.CrmLookupEntities)
            {
                var node = new TreeNode(en.LogicalName);
                node.Tag = en;
                TVEntityLookup.Nodes.Add(node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            var node = e.Node;

            if (node.Tag == null)
                return;

            var ca = (CrmLookupEntity)node.Tag;

            LVCompareResult.Items.Clear();

            DisplayLookups(ca.CommonLookups, Color.White, Color.Black);
            DisplayLookups(ca.LeftOnlyLookups, Color.White, Color.Green);
            DisplayLookups(ca.RightOnlyLookups, Color.White, Color.Blue);


            LVCompareResult.Refresh();

        }

        public void DisplayLookups(List<CrmLookup> list, Color bgColor, Color fgColor)
        {
            foreach (var o in list)
            {
                ListViewItem item = new ListViewItem(o.Id.ToString());
                item.SubItems.Add(o.Name);
                //item.SubItems.Add(o.Usage ? "Yes" : "No");
                //item.SubItems.Add(o.AllUsage ? "Yes" : "No");
                //item.SubItems.Add(o.AllUsageEntities);
                item.BackColor = bgColor;
                item.ForeColor = fgColor;
                LVCompareResult.Items.Add(item);
            }
        }

        private void loadLookupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App.CrmLookupEntities.Clear();

            foreach (var name in Setting.LookupEntitiesValue.Split(','))
            {
                var en = new CrmLookupEntity()
                {
                    LogicalName = name
                };

                App.CrmLookupEntities.Add(en);

                var node = new TreeNode(name);
                TVEntityLookup.Nodes.Add(node);
            }


            DisplayLookupTree();
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var le in App.CrmLookupEntities)
            {

                try
                {
                    var qe = new QueryExpression(le.LogicalName);

                    var primaryAttrName = "tri_name";

                    if (le.LogicalName.IndexOf("tri_") < 0)
                        primaryAttrName = "kc_name";

                    qe.TopCount = 50;
                    qe.ColumnSet = new ColumnSet(primaryAttrName);

                    var records = CrmConnManager.LService.RetrieveMultiple(qe).Entities;
                    foreach (var r in records)
                    {
                        le.LLookups.Add(new CrmLookup()
                        {
                            Id = r.Id,
                            Name = r.GetAttributeValue<string>(primaryAttrName)
                        });

                    }
                    records = CrmConnManager.RService.RetrieveMultiple(qe).Entities;
                    foreach (var r in records)
                    {
                        le.RLookups.Add(new CrmLookup()
                        {
                            Id = r.Id,
                            Name = r.GetAttributeValue<string>(primaryAttrName)
                        });

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}");
                
                }




            }

            LookupManager.Compare();

        }
    }
}
