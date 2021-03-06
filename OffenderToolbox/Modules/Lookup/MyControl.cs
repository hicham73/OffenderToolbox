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

namespace MigrationHelper.Modules.Lookup
{
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        private void DisplayLookupTree()
        {
            TVEntityLookup.Nodes.Clear();

            foreach (var ce in App.MigEntities)
            {
                var node = new TreeNode(ce.LogicalName);
                TVEntityLookup.Nodes.Add(node);
                foreach (var ca in ce.LookupAttributes)
                {
                    var an = new TreeNode(ca.Name);
                    if (ca.LookupEntity.LeftOnlyLookups.Count > 0 || ca.LookupEntity.RightOnlyLookups.Count > 0)
                    {
                        an.BackColor = Color.Red;
                        an.ForeColor = Color.White;
                    }

                    an.Tag = ca;
                    node.Nodes.Add(an);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            var node = e.Node;

            if (node.Tag == null)
                return;

            var ca = ((CrmLookupAttribute)node.Tag).LookupEntity;

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
            LoadData();

            DisplayLookupTree();
        }

        private void LoadData()
        {
            Console.WriteLine($"Crm Lookups count: {App.CrmLookupEntities.Count}");

            int count = 0;
            int count2 = 0;

            foreach (var le in App.CrmLookupEntities)
            {

                count++;

                //if (count > 50)
                //    continue;

                if (count % 20 == 0)
                    Console.WriteLine($"Count =====> {count} ===> count 2 ====> {count2}");

                try
                {
                    var qe = new QueryExpression(le.LogicalName);

                    qe.TopCount = 101;
                    qe.ColumnSet = new ColumnSet(true);

                    var lrecords = CrmConnManager.LService.RetrieveMultiple(qe).Entities;
                    var rrecords = CrmConnManager.RService.RetrieveMultiple(qe).Entities;

                    if (lrecords.Count > 100 || rrecords.Count > 100)
                        continue;

                    count2++;

                    foreach (var r in lrecords)
                    {
                        le.LLookups.Add(new CrmLookup()
                        {
                            Id = r.Id,
                            Name = r.GetAttributeValue<string>(le.PrimaryNameAttribute)
                        });

                    }
                    foreach (var r in rrecords)
                    {
                        le.RLookups.Add(new CrmLookup()
                        {
                            Id = r.Id,
                            Name = r.GetAttributeValue<string>(le.PrimaryNameAttribute)
                        });

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                
                }
            }
            Manager.Compare();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var csvFile = new CSVFile()
            {
                FileName = "LookupsReport.csv"
            };

            foreach (var le in App.CrmLookupEntities)
            {

                    var bloc = new CSVBloc()
                    {
                        EntityName = le.LogicalName,
                        AttributeName = ""
                    };

                    csvFile.Blocs.Add(bloc);

                    
                    if (le.LeftOnlyLookups.Count > 0 || le.RightOnlyLookups.Count > 0)
                    {

                        foreach (var o in le.CommonLookups)
                        {
                            bloc.AddRow(new string[] { o.Name, o.Name });
                        }
                        foreach (var o in le.LeftOnlyLookups)
                        {
                            bloc.AddRow(new string[] { o.Name, "" });
                        }
                        foreach (var o in le.RightOnlyLookups)
                        {
                            bloc.AddRow(new string[] { "", o.Name });
                        }
                    }
            }

            csvFile.Export();
        }
    }
}
