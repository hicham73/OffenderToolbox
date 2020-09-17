namespace MigrationHelper
{
    partial class SettingControl
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
            this.LVMetaEntities = new System.Windows.Forms.ListView();
            this.LVOptionEntities = new System.Windows.Forms.ListView();
            this.LVLookupEntities = new System.Windows.Forms.ListView();
            this.BtnAddOptionEntity = new System.Windows.Forms.Button();
            this.BtnRemoveOptionEntity = new System.Windows.Forms.Button();
            this.BtnRemoveLookupEntity = new System.Windows.Forms.Button();
            this.BtnAddLookupEntity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLoadEntities = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LVMetaEntities
            // 
            this.LVMetaEntities.CheckBoxes = true;
            this.LVMetaEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LVMetaEntities.GridLines = true;
            this.LVMetaEntities.HideSelection = false;
            this.LVMetaEntities.Location = new System.Drawing.Point(20, 69);
            this.LVMetaEntities.Name = "LVMetaEntities";
            this.LVMetaEntities.Size = new System.Drawing.Size(284, 517);
            this.LVMetaEntities.TabIndex = 0;
            this.LVMetaEntities.UseCompatibleStateImageBehavior = false;
            this.LVMetaEntities.View = System.Windows.Forms.View.Details;
            // 
            // LVOptionEntities
            // 
            this.LVOptionEntities.CheckBoxes = true;
            this.LVOptionEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.LVOptionEntities.HideSelection = false;
            this.LVOptionEntities.Location = new System.Drawing.Point(328, 69);
            this.LVOptionEntities.Name = "LVOptionEntities";
            this.LVOptionEntities.Size = new System.Drawing.Size(265, 517);
            this.LVOptionEntities.TabIndex = 1;
            this.LVOptionEntities.UseCompatibleStateImageBehavior = false;
            this.LVOptionEntities.View = System.Windows.Forms.View.Details;
            // 
            // LVLookupEntities
            // 
            this.LVLookupEntities.CheckBoxes = true;
            this.LVLookupEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.LVLookupEntities.HideSelection = false;
            this.LVLookupEntities.Location = new System.Drawing.Point(619, 70);
            this.LVLookupEntities.Name = "LVLookupEntities";
            this.LVLookupEntities.Size = new System.Drawing.Size(258, 517);
            this.LVLookupEntities.TabIndex = 2;
            this.LVLookupEntities.UseCompatibleStateImageBehavior = false;
            this.LVLookupEntities.View = System.Windows.Forms.View.Details;
            // 
            // BtnAddOptionEntity
            // 
            this.BtnAddOptionEntity.Location = new System.Drawing.Point(328, 593);
            this.BtnAddOptionEntity.Name = "BtnAddOptionEntity";
            this.BtnAddOptionEntity.Size = new System.Drawing.Size(112, 23);
            this.BtnAddOptionEntity.TabIndex = 3;
            this.BtnAddOptionEntity.Text = "Add";
            this.BtnAddOptionEntity.UseVisualStyleBackColor = true;
            this.BtnAddOptionEntity.Click += new System.EventHandler(this.BtnAddOptionEntity_Click);
            // 
            // BtnRemoveOptionEntity
            // 
            this.BtnRemoveOptionEntity.Location = new System.Drawing.Point(488, 593);
            this.BtnRemoveOptionEntity.Name = "BtnRemoveOptionEntity";
            this.BtnRemoveOptionEntity.Size = new System.Drawing.Size(105, 23);
            this.BtnRemoveOptionEntity.TabIndex = 4;
            this.BtnRemoveOptionEntity.Text = "Remove";
            this.BtnRemoveOptionEntity.UseVisualStyleBackColor = true;
            this.BtnRemoveOptionEntity.Click += new System.EventHandler(this.BtnRemoveOptionEntity_Click);
            // 
            // BtnRemoveLookupEntity
            // 
            this.BtnRemoveLookupEntity.Location = new System.Drawing.Point(778, 593);
            this.BtnRemoveLookupEntity.Name = "BtnRemoveLookupEntity";
            this.BtnRemoveLookupEntity.Size = new System.Drawing.Size(99, 23);
            this.BtnRemoveLookupEntity.TabIndex = 6;
            this.BtnRemoveLookupEntity.Text = "Remove";
            this.BtnRemoveLookupEntity.UseVisualStyleBackColor = true;
            this.BtnRemoveLookupEntity.Click += new System.EventHandler(this.BtnRemoveLookupEntity_Click);
            // 
            // BtnAddLookupEntity
            // 
            this.BtnAddLookupEntity.Location = new System.Drawing.Point(619, 593);
            this.BtnAddLookupEntity.Name = "BtnAddLookupEntity";
            this.BtnAddLookupEntity.Size = new System.Drawing.Size(105, 23);
            this.BtnAddLookupEntity.TabIndex = 5;
            this.BtnAddLookupEntity.Text = "Add";
            this.BtnAddLookupEntity.UseVisualStyleBackColor = true;
            this.BtnAddLookupEntity.Click += new System.EventHandler(this.BtnAddLookupEntity_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(328, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "OptionSet Entities Filter";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(616, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "OptionSet Entities Filter";
            // 
            // BtnLoadEntities
            // 
            this.BtnLoadEntities.Location = new System.Drawing.Point(20, 592);
            this.BtnLoadEntities.Name = "BtnLoadEntities";
            this.BtnLoadEntities.Size = new System.Drawing.Size(112, 23);
            this.BtnLoadEntities.TabIndex = 9;
            this.BtnLoadEntities.Text = "Load Entities";
            this.BtnLoadEntities.UseVisualStyleBackColor = true;
            this.BtnLoadEntities.Click += new System.EventHandler(this.BtnLoadEntities_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Meta Entities";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 246;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 259;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLoadEntities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemoveLookupEntity);
            this.Controls.Add(this.BtnAddLookupEntity);
            this.Controls.Add(this.BtnRemoveOptionEntity);
            this.Controls.Add(this.BtnAddOptionEntity);
            this.Controls.Add(this.LVLookupEntities);
            this.Controls.Add(this.LVOptionEntities);
            this.Controls.Add(this.LVMetaEntities);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(997, 680);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVMetaEntities;
        private System.Windows.Forms.ListView LVOptionEntities;
        private System.Windows.Forms.ListView LVLookupEntities;
        private System.Windows.Forms.Button BtnAddOptionEntity;
        private System.Windows.Forms.Button BtnRemoveOptionEntity;
        private System.Windows.Forms.Button BtnRemoveLookupEntity;
        private System.Windows.Forms.Button BtnAddLookupEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLoadEntities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
