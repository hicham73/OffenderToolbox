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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvEntities = new System.Windows.Forms.TreeView();
            this.lvCompareResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnLoadOptions = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.BtnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.scOptionModule = new System.Windows.Forms.SplitContainer();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPageOptionSets = new System.Windows.Forms.TabPage();
            this.tabPageFormulas = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvFormulaEntities = new System.Windows.Forms.TreeView();
            this.dataGridFormula = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnLoadFormulas = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnConnect = new System.Windows.Forms.ToolStripButton();
            this.BtnSettings = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOptionModule)).BeginInit();
            this.scOptionModule.Panel1.SuspendLayout();
            this.scOptionModule.Panel2.SuspendLayout();
            this.scOptionModule.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPageOptionSets.SuspendLayout();
            this.tabPageFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormula)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvEntities);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvCompareResult);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 531);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvEntities
            // 
            this.tvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEntities.Location = new System.Drawing.Point(0, 0);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(230, 531);
            this.tvEntities.TabIndex = 0;
            this.tvEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEntities_AfterSelect);
            // 
            // lvCompareResult
            // 
            this.lvCompareResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCompareResult.GridLines = true;
            this.lvCompareResult.HideSelection = false;
            this.lvCompareResult.Location = new System.Drawing.Point(0, 0);
            this.lvCompareResult.Name = "lvCompareResult";
            this.lvCompareResult.Size = new System.Drawing.Size(966, 531);
            this.lvCompareResult.TabIndex = 0;
            this.lvCompareResult.UseCompatibleStateImageBehavior = false;
            this.lvCompareResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Value";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 350;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadOptions,
            this.BtnRefresh,
            this.BtnExportToExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnLoadOptions
            // 
            this.BtnLoadOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnLoadOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoadOptions.Image")));
            this.BtnLoadOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoadOptions.Name = "BtnLoadOptions";
            this.BtnLoadOptions.Size = new System.Drawing.Size(82, 22);
            this.BtnLoadOptions.Text = "Load Options";
            this.BtnLoadOptions.Click += new System.EventHandler(this.BtnLoadOptions_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(50, 22);
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportToExcel.Image")));
            this.BtnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(89, 22);
            this.BtnExportToExcel.Text = "Export to Excel";
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // scOptionModule
            // 
            this.scOptionModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOptionModule.Location = new System.Drawing.Point(3, 3);
            this.scOptionModule.Name = "scOptionModule";
            this.scOptionModule.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOptionModule.Panel1
            // 
            this.scOptionModule.Panel1.Controls.Add(this.toolStrip1);
            // 
            // scOptionModule.Panel2
            // 
            this.scOptionModule.Panel2.Controls.Add(this.splitContainer1);
            this.scOptionModule.Size = new System.Drawing.Size(1200, 560);
            this.scOptionModule.SplitterDistance = 25;
            this.scOptionModule.TabIndex = 4;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPageOptionSets);
            this.tcMain.Controls.Add(this.tabPageFormulas);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1214, 592);
            this.tcMain.TabIndex = 5;
            // 
            // tabPageOptionSets
            // 
            this.tabPageOptionSets.Controls.Add(this.scOptionModule);
            this.tabPageOptionSets.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptionSets.Name = "tabPageOptionSets";
            this.tabPageOptionSets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptionSets.Size = new System.Drawing.Size(1206, 566);
            this.tabPageOptionSets.TabIndex = 0;
            this.tabPageOptionSets.Text = "OptionSets";
            this.tabPageOptionSets.UseVisualStyleBackColor = true;
            // 
            // tabPageFormulas
            // 
            this.tabPageFormulas.Controls.Add(this.splitContainer2);
            this.tabPageFormulas.Controls.Add(this.menuStrip1);
            this.tabPageFormulas.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormulas.Name = "tabPageFormulas";
            this.tabPageFormulas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormulas.Size = new System.Drawing.Size(1206, 566);
            this.tabPageFormulas.TabIndex = 1;
            this.tabPageFormulas.Text = "N52 - Formulas";
            this.tabPageFormulas.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 27);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvFormulaEntities);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridFormula);
            this.splitContainer2.Size = new System.Drawing.Size(1200, 536);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 1;
            // 
            // tvFormulaEntities
            // 
            this.tvFormulaEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFormulaEntities.Location = new System.Drawing.Point(0, 0);
            this.tvFormulaEntities.Name = "tvFormulaEntities";
            this.tvFormulaEntities.Size = new System.Drawing.Size(213, 536);
            this.tvFormulaEntities.TabIndex = 0;
            this.tvFormulaEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFormulaEntities_AfterSelect);
            // 
            // dataGridFormula
            // 
            this.dataGridFormula.AllowUserToDeleteRows = false;
            this.dataGridFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Name,
            this.Type,
            this.TargetEntity,
            this.TargetProperty,
            this.State,
            this.Status});
            this.dataGridFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFormula.Location = new System.Drawing.Point(0, 0);
            this.dataGridFormula.Name = "dataGridFormula";
            this.dataGridFormula.Size = new System.Drawing.Size(983, 536);
            this.dataGridFormula.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadFormulas,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnLoadFormulas
            // 
            this.BtnLoadFormulas.Name = "BtnLoadFormulas";
            this.BtnLoadFormulas.Size = new System.Drawing.Size(97, 20);
            this.BtnLoadFormulas.Text = "Load Formulas";
            this.BtnLoadFormulas.Click += new System.EventHandler(this.BtnLoadFormulas_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tcMain);
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
            this.BtnSettings});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(153, 25);
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
            // BtnSettings
            // 
            this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
            this.BtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(69, 22);
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.ToolTipText = "Settings";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 300;
            this.Name.Name = "Name";
            this.Name.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // TargetEntity
            // 
            this.TargetEntity.HeaderText = "Target Entity";
            this.TargetEntity.Name = "TargetEntity";
            // 
            // TargetProperty
            // 
            this.TargetProperty.HeaderText = "Target Property";
            this.TargetProperty.Name = "TargetProperty";
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 617);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            //this.Name = "MainForm";
            this.Text = "Offender ToolBox";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.scOptionModule.Panel1.ResumeLayout(false);
            this.scOptionModule.Panel1.PerformLayout();
            this.scOptionModule.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOptionModule)).EndInit();
            this.scOptionModule.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabPageOptionSets.ResumeLayout(false);
            this.tabPageFormulas.ResumeLayout(false);
            this.tabPageFormulas.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormula)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvCompareResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnLoadOptions;
        private System.Windows.Forms.SplitContainer scOptionModule;
        private System.Windows.Forms.TreeView tvEntities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripButton BtnExportToExcel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPageOptionSets;
        private System.Windows.Forms.TabPage tabPageFormulas;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnConnect;
        private System.Windows.Forms.ToolStripButton BtnSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnLoadFormulas;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvFormulaEntities;
        private System.Windows.Forms.DataGridView dataGridFormula;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

