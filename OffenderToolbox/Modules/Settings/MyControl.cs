using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace MigrationHelper.Modules.Setting
{
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();

            
        }

        private void BtnLoadEntities_Click(object sender, EventArgs e)
        {

            foreach (var em in App.AllEntities)
            {
                LVMetaEntities.Items.Add(new ListViewItem(em.LogicalName));
            }

        }

        private void BtnAddOptionEntity_Click(object sender, EventArgs e)
        {
            var list = LVMetaEntities.CheckedItems;

            foreach (ListViewItem item in list)
            {
                if (LVOptionEntities.Items.IndexOf(item) < 0)
                {
                    LVOptionEntities.Items.Add(new ListViewItem(item.Text));
                }
            }
        }

        internal void LoadControl()
        {
            foreach (var e in App.AllEntities)
            {
                LVMetaEntities.Items.Add(new ListViewItem(e.LogicalName));
            }

        }

        private void BtnAddLookupEntity_Click(object sender, EventArgs e)
        {
            var list = LVMetaEntities.CheckedItems;

            foreach (ListViewItem item in list)
            {
                if (LVLookupEntities.Items.IndexOf(item) < 0)
                {
                    LVLookupEntities.Items.Add(new ListViewItem(item.Text));
                }
            }

        }

        private void BtnRemoveOptionEntity_Click(object sender, EventArgs e)
        {
            var list = LVOptionEntities.CheckedItems;

            foreach (ListViewItem item in list)
            {
                LVOptionEntities.Items.Remove(item);
            }

        }

        private void BtnRemoveLookupEntity_Click(object sender, EventArgs e)
        {
            var list = LVLookupEntities.CheckedItems;

            foreach (ListViewItem item in list)
            {
                LVLookupEntities.Items.Remove(item);
            }
        }
    }
}
