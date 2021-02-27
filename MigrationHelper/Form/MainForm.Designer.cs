namespace MigrationHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.PageSetting = new System.Windows.Forms.TabPage();
            this.settingControl1 = new MigrationHelper.Modules.Setting.MyControl();
            this.PageOptionSet = new System.Windows.Forms.TabPage();
            this.optionSetControl1 = new MigrationHelper.Modules.Option.MyControl();
            this.PageLookup = new System.Windows.Forms.TabPage();
            this.lookupControl1 = new MigrationHelper.Modules.Lookup.MyControl();
            this.PageFormula = new System.Windows.Forms.TabPage();
            this.formulaControl1 = new MigrationHelper.Modules.Formula.MyControl();
            this.tabTaskRunner = new System.Windows.Forms.TabPage();
            this.myTaskRunner = new MigrationHelper.Modules.Task.MyControl();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnConnect = new System.Windows.Forms.ToolStripButton();
            this.BtnLoadMeta = new System.Windows.Forms.ToolStripButton();
            this.BtnSettings = new System.Windows.Forms.ToolStripButton();
            this.BtnLeftConnect = new System.Windows.Forms.ToolStripButton();
            this.BtnRightConnect = new System.Windows.Forms.ToolStripButton();
            this.TabControlMain.SuspendLayout();
            this.PageSetting.SuspendLayout();
            this.PageOptionSet.SuspendLayout();
            this.PageLookup.SuspendLayout();
            this.PageFormula.SuspendLayout();
            this.tabTaskRunner.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.PageSetting);
            this.TabControlMain.Controls.Add(this.PageOptionSet);
            this.TabControlMain.Controls.Add(this.PageLookup);
            this.TabControlMain.Controls.Add(this.PageFormula);
            this.TabControlMain.Controls.Add(this.tabTaskRunner);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1214, 592);
            this.TabControlMain.TabIndex = 5;
            // 
            // PageSetting
            // 
            this.PageSetting.Controls.Add(this.settingControl1);
            this.PageSetting.Location = new System.Drawing.Point(4, 22);
            this.PageSetting.Name = "PageSetting";
            this.PageSetting.Size = new System.Drawing.Size(1206, 566);
            this.PageSetting.TabIndex = 3;
            this.PageSetting.Text = "Settings";
            this.PageSetting.UseVisualStyleBackColor = true;
            // 
            // settingControl1
            // 
            this.settingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingControl1.Location = new System.Drawing.Point(0, 0);
            this.settingControl1.Name = "settingControl1";
            this.settingControl1.Size = new System.Drawing.Size(1206, 566);
            this.settingControl1.TabIndex = 0;
            // 
            // PageOptionSet
            // 
            this.PageOptionSet.Controls.Add(this.optionSetControl1);
            this.PageOptionSet.Location = new System.Drawing.Point(4, 22);
            this.PageOptionSet.Name = "PageOptionSet";
            this.PageOptionSet.Padding = new System.Windows.Forms.Padding(3);
            this.PageOptionSet.Size = new System.Drawing.Size(1206, 566);
            this.PageOptionSet.TabIndex = 2;
            this.PageOptionSet.Text = "Option Sets";
            this.PageOptionSet.UseVisualStyleBackColor = true;
            // 
            // optionSetControl1
            // 
            this.optionSetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionSetControl1.Location = new System.Drawing.Point(3, 3);
            this.optionSetControl1.Name = "optionSetControl1";
            this.optionSetControl1.Size = new System.Drawing.Size(1200, 560);
            this.optionSetControl1.TabIndex = 0;
            // 
            // PageLookup
            // 
            this.PageLookup.Controls.Add(this.lookupControl1);
            this.PageLookup.Location = new System.Drawing.Point(4, 22);
            this.PageLookup.Name = "PageLookup";
            this.PageLookup.Padding = new System.Windows.Forms.Padding(3);
            this.PageLookup.Size = new System.Drawing.Size(1206, 566);
            this.PageLookup.TabIndex = 4;
            this.PageLookup.Text = "Lookups";
            this.PageLookup.UseVisualStyleBackColor = true;
            // 
            // lookupControl1
            // 
            this.lookupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookupControl1.Location = new System.Drawing.Point(3, 3);
            this.lookupControl1.Name = "lookupControl1";
            this.lookupControl1.Size = new System.Drawing.Size(1200, 560);
            this.lookupControl1.TabIndex = 0;
            // 
            // PageFormula
            // 
            this.PageFormula.Controls.Add(this.formulaControl1);
            this.PageFormula.Location = new System.Drawing.Point(4, 22);
            this.PageFormula.Name = "PageFormula";
            this.PageFormula.Padding = new System.Windows.Forms.Padding(3);
            this.PageFormula.Size = new System.Drawing.Size(1206, 566);
            this.PageFormula.TabIndex = 1;
            this.PageFormula.Text = "N52 - Formulas";
            this.PageFormula.UseVisualStyleBackColor = true;
            // 
            // formulaControl1
            // 
            this.formulaControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formulaControl1.Location = new System.Drawing.Point(3, 3);
            this.formulaControl1.Name = "formulaControl1";
            this.formulaControl1.Size = new System.Drawing.Size(1200, 560);
            this.formulaControl1.TabIndex = 0;
            // 
            // tabTaskRunner
            // 
            this.tabTaskRunner.Controls.Add(this.myTaskRunner);
            this.tabTaskRunner.Location = new System.Drawing.Point(4, 22);
            this.tabTaskRunner.Name = "tabTaskRunner";
            this.tabTaskRunner.Size = new System.Drawing.Size(1206, 566);
            this.tabTaskRunner.TabIndex = 5;
            this.tabTaskRunner.Text = "Task Runner";
            this.tabTaskRunner.UseVisualStyleBackColor = true;
            // 
            // myTaskRunner
            // 
            this.myTaskRunner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTaskRunner.Location = new System.Drawing.Point(0, 0);
            this.myTaskRunner.Name = "myTaskRunner";
            this.myTaskRunner.Size = new System.Drawing.Size(1206, 566);
            this.myTaskRunner.TabIndex = 0;
            this.myTaskRunner.Load += new System.EventHandler(this.myTaskRunner_Load);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TabControlMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1214, 592);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1214, 617);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConnect,
            this.BtnLoadMeta,
            this.BtnSettings,
            this.BtnLeftConnect,
            this.BtnRightConnect});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(465, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnConnect.Image")));
            this.BtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(72, 22);
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnLoadMeta
            // 
            this.BtnLoadMeta.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoadMeta.Image")));
            this.BtnLoadMeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoadMeta.Name = "BtnLoadMeta";
            this.BtnLoadMeta.Size = new System.Drawing.Size(83, 22);
            this.BtnLoadMeta.Text = "Load Meta";
            this.BtnLoadMeta.Click += new System.EventHandler(this.BtnLoadMeta_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
            this.BtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(69, 22);
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.ToolTipText = "Settings";
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnLeftConnect
            // 
            this.BtnLeftConnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeftConnect.Image")));
            this.BtnLeftConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLeftConnect.Name = "BtnLeftConnect";
            this.BtnLeftConnect.Size = new System.Drawing.Size(95, 22);
            this.BtnLeftConnect.Text = "Left Connect";
            this.BtnLeftConnect.Click += new System.EventHandler(this.BtnLeftConnect_Click);
            // 
            // BtnRightConnect
            // 
            this.BtnRightConnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnRightConnect.Image")));
            this.BtnRightConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRightConnect.Name = "BtnRightConnect";
            this.BtnRightConnect.Size = new System.Drawing.Size(103, 22);
            this.BtnRightConnect.Text = "Right Connect";
            this.BtnRightConnect.Click += new System.EventHandler(this.BtnRightConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 617);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "Offender ToolBox";
            this.TabControlMain.ResumeLayout(false);
            this.PageSetting.ResumeLayout(false);
            this.PageOptionSet.ResumeLayout(false);
            this.PageLookup.ResumeLayout(false);
            this.PageFormula.ResumeLayout(false);
            this.tabTaskRunner.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage PageFormula;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnConnect;
        private System.Windows.Forms.ToolStripButton BtnSettings;
        private System.Windows.Forms.TabPage PageOptionSet;
        private Modules.Option.MyControl optionSetControl1;
        private Modules.Formula.MyControl formulaControl1;
        private System.Windows.Forms.TabPage PageSetting;
        private MigrationHelper.Modules.Setting.MyControl settingControl1;
        private System.Windows.Forms.TabPage PageLookup;
        private Modules.Lookup.MyControl lookupControl1;
        private System.Windows.Forms.TabPage tabTaskRunner;
        private Modules.Task.MyControl myTaskRunner;
        private System.Windows.Forms.ToolStripButton BtnLoadMeta;
        private System.Windows.Forms.ToolStripButton BtnLeftConnect;
        private System.Windows.Forms.ToolStripButton BtnRightConnect;
    }
}

