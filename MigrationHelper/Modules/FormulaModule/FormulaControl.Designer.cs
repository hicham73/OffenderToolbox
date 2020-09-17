namespace MigrationHelper
{
    partial class FormulaControl
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
            this.dataGridFormula = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnLoadFormulas = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormulaCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FormulaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFormula)).BeginInit();
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
            this.splitContainer2.Panel2.Controls.Add(this.dataGridFormula);
            this.splitContainer2.Size = new System.Drawing.Size(1041, 697);
            this.splitContainer2.SplitterDistance = 184;
            this.splitContainer2.TabIndex = 2;
            // 
            // tvFormulaEntities
            // 
            this.tvFormulaEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFormulaEntities.Location = new System.Drawing.Point(0, 0);
            this.tvFormulaEntities.Name = "tvFormulaEntities";
            this.tvFormulaEntities.Size = new System.Drawing.Size(184, 697);
            this.tvFormulaEntities.TabIndex = 0;
            this.tvFormulaEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvEntities_AfterSelect);
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
            this.dataGridFormula.Size = new System.Drawing.Size(853, 697);
            this.dataGridFormula.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoadFormulas,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
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
            this.FormulaName.Width = 300;
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
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1041, 697);
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
            // FormulaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormulaControl";
            this.Size = new System.Drawing.Size(1041, 721);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvFormulaEntities;
        private System.Windows.Forms.DataGridView dataGridFormula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnLoadFormulas;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FormulaCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormulaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}
