namespace MigrationHelper.Modules.Formula
{
    partial class MyControl
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvFormulaEntities = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridFormula = new System.Windows.Forms.DataGridView();
            this.FormulaCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FormulaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRightOrgName = new System.Windows.Forms.Label();
            this.txtLeftFormula = new System.Windows.Forms.RichTextBox();
            this.txtRightFormula = new System.Windows.Forms.RichTextBox();
            this.lblLeftOrgName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnLoadFormulas = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOpenInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtnDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.BtnDeactivateFormulas = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormula)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvFormulaEntities);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1041, 694);
            this.splitContainer2.SplitterDistance = 184;
            this.splitContainer2.TabIndex = 2;
            // 
            // tvFormulaEntities
            // 
            this.tvFormulaEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFormulaEntities.Location = new System.Drawing.Point(0, 0);
            this.tvFormulaEntities.Name = "tvFormulaEntities";
            this.tvFormulaEntities.Size = new System.Drawing.Size(184, 694);
            this.tvFormulaEntities.TabIndex = 0;
            this.tvFormulaEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvEntities_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridFormula);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(853, 694);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridFormula
            // 
            this.dataGridFormula.AllowUserToDeleteRows = false;
            this.dataGridFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormulaCheckbox,
            this.FormulaName,
            this.Type,
            this.TargetEntity,
            this.TargetProperty,
            this.State,
            this.Status});
            this.dataGridFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFormula.Location = new System.Drawing.Point(0, 0);
            this.dataGridFormula.Name = "dataGridFormula";
            this.dataGridFormula.Size = new System.Drawing.Size(853, 484);
            this.dataGridFormula.TabIndex = 0;
            this.dataGridFormula.SelectionChanged += new System.EventHandler(this.dataGridFormula_SelectionChanged);
            // 
            // FormulaCheckbox
            // 
            this.FormulaCheckbox.HeaderText = "S";
            this.FormulaCheckbox.Name = "FormulaCheckbox";
            this.FormulaCheckbox.Width = 25;
            // 
            // FormulaName
            // 
            this.FormulaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FormulaName.HeaderText = "Name";
            this.FormulaName.MinimumWidth = 300;
            this.FormulaName.Name = "FormulaName";
            this.FormulaName.ReadOnly = true;
            this.FormulaName.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // TargetEntity
            // 
            this.TargetEntity.HeaderText = "Target Entity";
            this.TargetEntity.Name = "TargetEntity";
            this.TargetEntity.ReadOnly = true;
            // 
            // TargetProperty
            // 
            this.TargetProperty.HeaderText = "Target Property";
            this.TargetProperty.Name = "TargetProperty";
            this.TargetProperty.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "L-Status";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "R-Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRightOrgName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLeftFormula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRightFormula, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLeftOrgName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRightOrgName
            // 
            this.lblRightOrgName.AutoSize = true;
            this.lblRightOrgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightOrgName.Location = new System.Drawing.Point(429, 186);
            this.lblRightOrgName.Name = "lblRightOrgName";
            this.lblRightOrgName.Size = new System.Drawing.Size(421, 20);
            this.lblRightOrgName.TabIndex = 3;
            this.lblRightOrgName.Text = "label1";
            // 
            // txtLeftFormula
            // 
            this.txtLeftFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftFormula.Location = new System.Drawing.Point(3, 3);
            this.txtLeftFormula.Name = "txtLeftFormula";
            this.txtLeftFormula.Size = new System.Drawing.Size(420, 180);
            this.txtLeftFormula.TabIndex = 0;
            this.txtLeftFormula.Text = "";
            // 
            // txtRightFormula
            // 
            this.txtRightFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightFormula.Location = new System.Drawing.Point(429, 3);
            this.txtRightFormula.Name = "txtRightFormula";
            this.txtRightFormula.Size = new System.Drawing.Size(421, 180);
            this.txtRightFormula.TabIndex = 1;
            this.txtRightFormula.Text = "";
            // 
            // lblLeftOrgName
            // 
            this.lblLeftOrgName.AutoSize = true;
            this.lblLeftOrgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftOrgName.Location = new System.Drawing.Point(3, 186);
            this.lblLeftOrgName.Name = "lblLeftOrgName";
            this.lblLeftOrgName.Size = new System.Drawing.Size(420, 20);
            this.lblLeftOrgName.TabIndex = 2;
            this.lblLeftOrgName.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadFormulas,
            this.refreshToolStripMenuItem,
            this.exportCSVToolStripMenuItem,
            this.BtnOpenInBrowser,
            this.txtSearch,
            this.BtnDeploy,
            this.BtnDeactivateFormulas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnLoadFormulas
            // 
            this.BtnLoadFormulas.Name = "BtnLoadFormulas";
            this.BtnLoadFormulas.Size = new System.Drawing.Size(97, 23);
            this.BtnLoadFormulas.Text = "Load Formulas";
            this.BtnLoadFormulas.Click += new System.EventHandler(this.BtnLoadFormulas_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.exportCSVToolStripMenuItem.Text = "Export CSV";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.exportCSVToolStripMenuItem_Click);
            // 
            // BtnOpenInBrowser
            // 
            this.BtnOpenInBrowser.Name = "BtnOpenInBrowser";
            this.BtnOpenInBrowser.Size = new System.Drawing.Size(106, 23);
            this.BtnOpenInBrowser.Text = "Open in Browser";
            this.BtnOpenInBrowser.Click += new System.EventHandler(this.BtnOpenInBrowser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // BtnDeploy
            // 
            this.BtnDeploy.Name = "BtnDeploy";
            this.BtnDeploy.Size = new System.Drawing.Size(56, 23);
            this.BtnDeploy.Text = "Deploy";
            this.BtnDeploy.Click += new System.EventHandler(this.BtnDeploy_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1041, 694);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1041, 721);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // BtnDeactivateFormulas
            // 
            this.BtnDeactivateFormulas.Name = "BtnDeactivateFormulas";
            this.BtnDeactivateFormulas.Size = new System.Drawing.Size(126, 23);
            this.BtnDeactivateFormulas.Text = "Deactivate Formulas";
            this.BtnDeactivateFormulas.Click += new System.EventHandler(this.BtnDeactivateFormulas_Click);
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(1041, 721);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormula)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvFormulaEntities;
        private System.Windows.Forms.DataGridView dataGridFormula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnLoadFormulas;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtLeftFormula;
        private System.Windows.Forms.RichTextBox txtRightFormula;
        private System.Windows.Forms.ToolStripMenuItem BtnOpenInBrowser;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.Label lblRightOrgName;
        private System.Windows.Forms.Label lblLeftOrgName;
        private System.Windows.Forms.ToolStripMenuItem BtnDeploy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FormulaCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormulaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem BtnDeactivateFormulas;
    }
}
