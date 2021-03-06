﻿using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using MigrationHelper.Shared;
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

            TabControlMain.TabPages.Remove(PageSetting);
            
            Setting.Load();

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            App.InitApp();

            MessageBox.Show("Connected successfully!");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            TabControlMain.TabPages.Add(PageSetting);

            TabControlMain.SelectedTab = PageSetting;

            settingControl1.LoadControl();

            PageSetting.Show();
        }

        private void BtnLoadMeta_Click(object sender, EventArgs e)
        {

            App.LoadAllEntities();

        }

        private void myTaskRunner_Load(object sender, EventArgs e)
        {

        }

        private void BtnLeftConnect_Click(object sender, EventArgs e)
        {
            CrmConnManager.LeftConnect();
        }

        private void BtnRightConnect_Click(object sender, EventArgs e)
        {
            CrmConnManager.RightConnect();
        }
    }
}
