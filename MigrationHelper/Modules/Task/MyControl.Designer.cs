namespace MigrationHelper.Modules.Task
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
            this.BtnBulkDelete = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSetMigEntities = new System.Windows.Forms.Button();
            this.BtnDeactivateFormulas = new System.Windows.Forms.Button();
            this.BtnActivateFormulas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBulkDelete
            // 
            this.BtnBulkDelete.Location = new System.Drawing.Point(649, 78);
            this.BtnBulkDelete.Name = "BtnBulkDelete";
            this.BtnBulkDelete.Size = new System.Drawing.Size(214, 23);
            this.BtnBulkDelete.TabIndex = 0;
            this.BtnBulkDelete.Text = "Bulk Delete";
            this.BtnBulkDelete.UseVisualStyleBackColor = true;
            this.BtnBulkDelete.Click += new System.EventHandler(this.BtnBulkDelete_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(4, 478);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(919, 317);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(4, 39);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(568, 433);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Parameters";
            // 
            // BtnSetMigEntities
            // 
            this.BtnSetMigEntities.Location = new System.Drawing.Point(649, 39);
            this.BtnSetMigEntities.Name = "BtnSetMigEntities";
            this.BtnSetMigEntities.Size = new System.Drawing.Size(214, 23);
            this.BtnSetMigEntities.TabIndex = 5;
            this.BtnSetMigEntities.Text = "Set Migration Entities";
            this.BtnSetMigEntities.UseVisualStyleBackColor = true;
            this.BtnSetMigEntities.Click += new System.EventHandler(this.BtnSetMigEntities_Click);
            // 
            // BtnDeactivateFormulas
            // 
            this.BtnDeactivateFormulas.Location = new System.Drawing.Point(649, 199);
            this.BtnDeactivateFormulas.Name = "BtnDeactivateFormulas";
            this.BtnDeactivateFormulas.Size = new System.Drawing.Size(214, 23);
            this.BtnDeactivateFormulas.TabIndex = 6;
            this.BtnDeactivateFormulas.Text = "Deactivate Formulas";
            this.BtnDeactivateFormulas.UseVisualStyleBackColor = true;
            this.BtnDeactivateFormulas.Click += new System.EventHandler(this.BtnDeactivateFormulas_Click);
            // 
            // BtnActivateFormulas
            // 
            this.BtnActivateFormulas.Location = new System.Drawing.Point(649, 245);
            this.BtnActivateFormulas.Name = "BtnActivateFormulas";
            this.BtnActivateFormulas.Size = new System.Drawing.Size(214, 23);
            this.BtnActivateFormulas.TabIndex = 7;
            this.BtnActivateFormulas.Text = "Activate Formulas";
            this.BtnActivateFormulas.UseVisualStyleBackColor = true;
            this.BtnActivateFormulas.Click += new System.EventHandler(this.BtnActivateFormulas_Click);
            // 
            // TaskRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnActivateFormulas);
            this.Controls.Add(this.BtnDeactivateFormulas);
            this.Controls.Add(this.BtnSetMigEntities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.BtnBulkDelete);
            this.Name = "TaskRunner";
            this.Size = new System.Drawing.Size(956, 821);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBulkDelete;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSetMigEntities;
        private System.Windows.Forms.Button BtnDeactivateFormulas;
        private System.Windows.Forms.Button BtnActivateFormulas;
    }
}
