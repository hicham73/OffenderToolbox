namespace MigrationHelper
{
    partial class OptionSetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionSetControl));
            this.scOptionModule = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnLoadOptions = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.BtnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvEntities = new System.Windows.Forms.TreeView();
            this.lvCompareResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGetOptionUsage = new System.Windows.Forms.ToolStripButton();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.scOptionModule)).BeginInit();
            this.scOptionModule.Panel1.SuspendLayout();
            this.scOptionModule.Panel2.SuspendLayout();
            this.scOptionModule.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scOptionModule
            // 
            this.scOptionModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOptionModule.Location = new System.Drawing.Point(0, 0);
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
            this.scOptionModule.Size = new System.Drawing.Size(1212, 664);
            this.scOptionModule.SplitterDistance = 34;
            this.scOptionModule.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadOptions,
            this.BtnRefresh,
            this.BtnExportToExcel,
            this.BtnGetOptionUsage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1212, 25);
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
            this.splitContainer1.Size = new System.Drawing.Size(1212, 626);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvEntities
            // 
            this.tvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEntities.Location = new System.Drawing.Point(0, 0);
            this.tvEntities.Name = "tvEntities";
            this.tvEntities.Size = new System.Drawing.Size(230, 626);
            this.tvEntities.TabIndex = 0;
            this.tvEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEntities_AfterSelect);
            // 
            // lvCompareResult
            // 
            this.lvCompareResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCompareResult.GridLines = true;
            this.lvCompareResult.HideSelection = false;
            this.lvCompareResult.Location = new System.Drawing.Point(0, 0);
            this.lvCompareResult.Name = "lvCompareResult";
            this.lvCompareResult.Size = new System.Drawing.Size(978, 626);
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
            // BtnGetOptionUsage
            // 
            this.BtnGetOptionUsage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnGetOptionUsage.Image = ((System.Drawing.Image)(resources.GetObject("BtnGetOptionUsage.Image")));
            this.BtnGetOptionUsage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGetOptionUsage.Name = "BtnGetOptionUsage";
            this.BtnGetOptionUsage.Size = new System.Drawing.Size(64, 22);
            this.BtnGetOptionUsage.Text = "Get Usage";
            this.BtnGetOptionUsage.Click += new System.EventHandler(this.BtnGetOptionUsage_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Is Used";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is Used (All Entities)";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Entities";
            this.columnHeader5.Width = 413;
            // 
            // OptionSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scOptionModule);
            this.Name = "OptionSetControl";
            this.Size = new System.Drawing.Size(1212, 664);
            this.scOptionModule.Panel1.ResumeLayout(false);
            this.scOptionModule.Panel1.PerformLayout();
            this.scOptionModule.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOptionModule)).EndInit();
            this.scOptionModule.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scOptionModule;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnLoadOptions;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripButton BtnExportToExcel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvEntities;
        private System.Windows.Forms.ListView lvCompareResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton BtnGetOptionUsage;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
