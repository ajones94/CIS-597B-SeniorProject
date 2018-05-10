namespace SQLDatabaseApp
{
    partial class UpdateData_Form
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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.UpdatedValue_Label = new System.Windows.Forms.Label();
            this.UpdatedValue_TxtBox = new System.Windows.Forms.TextBox();
            this.WhereToApply_TxtBox = new System.Windows.Forms.TextBox();
            this.ColumnToApply_Label = new System.Windows.Forms.Label();
            this.Instruction_Label = new System.Windows.Forms.Label();
            this.UpdateColumn_Label = new System.Windows.Forms.Label();
            this.UpdatedColumn_TxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RowValueToUpdate_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(39, 258);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(796, 62);
            this.Submit_Button.TabIndex = 0;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // UpdatedValue_Label
            // 
            this.UpdatedValue_Label.AutoSize = true;
            this.UpdatedValue_Label.Location = new System.Drawing.Point(34, 130);
            this.UpdatedValue_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UpdatedValue_Label.Name = "UpdatedValue_Label";
            this.UpdatedValue_Label.Size = new System.Drawing.Size(154, 25);
            this.UpdatedValue_Label.TabIndex = 1;
            this.UpdatedValue_Label.Text = "Updated Value";
            // 
            // UpdatedValue_TxtBox
            // 
            this.UpdatedValue_TxtBox.Location = new System.Drawing.Point(477, 124);
            this.UpdatedValue_TxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdatedValue_TxtBox.Name = "UpdatedValue_TxtBox";
            this.UpdatedValue_TxtBox.Size = new System.Drawing.Size(358, 31);
            this.UpdatedValue_TxtBox.TabIndex = 2;
            // 
            // WhereToApply_TxtBox
            // 
            this.WhereToApply_TxtBox.Location = new System.Drawing.Point(477, 167);
            this.WhereToApply_TxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.WhereToApply_TxtBox.Name = "WhereToApply_TxtBox";
            this.WhereToApply_TxtBox.Size = new System.Drawing.Size(358, 31);
            this.WhereToApply_TxtBox.TabIndex = 3;
            // 
            // ColumnToApply_Label
            // 
            this.ColumnToApply_Label.AutoSize = true;
            this.ColumnToApply_Label.Location = new System.Drawing.Point(34, 173);
            this.ColumnToApply_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ColumnToApply_Label.Name = "ColumnToApply_Label";
            this.ColumnToApply_Label.Size = new System.Drawing.Size(363, 25);
            this.ColumnToApply_Label.TabIndex = 4;
            this.ColumnToApply_Label.Text = "Column where update will be applied";
            // 
            // Instruction_Label
            // 
            this.Instruction_Label.AutoSize = true;
            this.Instruction_Label.Location = new System.Drawing.Point(92, 29);
            this.Instruction_Label.Name = "Instruction_Label";
            this.Instruction_Label.Size = new System.Drawing.Size(688, 25);
            this.Instruction_Label.TabIndex = 5;
            this.Instruction_Label.Text = "Please provide necessary information to Update a Column with a value";
            // 
            // UpdateColumn_Label
            // 
            this.UpdateColumn_Label.AutoSize = true;
            this.UpdateColumn_Label.Location = new System.Drawing.Point(34, 90);
            this.UpdateColumn_Label.Name = "UpdateColumn_Label";
            this.UpdateColumn_Label.Size = new System.Drawing.Size(184, 25);
            this.UpdateColumn_Label.TabIndex = 6;
            this.UpdateColumn_Label.Text = "Column to Update";
            // 
            // UpdatedColumn_TxtBox
            // 
            this.UpdatedColumn_TxtBox.Location = new System.Drawing.Point(477, 84);
            this.UpdatedColumn_TxtBox.Multiline = true;
            this.UpdatedColumn_TxtBox.Name = "UpdatedColumn_TxtBox";
            this.UpdatedColumn_TxtBox.Size = new System.Drawing.Size(358, 31);
            this.UpdatedColumn_TxtBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Row of Column to apply update";
            // 
            // RowValueToUpdate_TxtBox
            // 
            this.RowValueToUpdate_TxtBox.Location = new System.Drawing.Point(477, 207);
            this.RowValueToUpdate_TxtBox.Multiline = true;
            this.RowValueToUpdate_TxtBox.Name = "RowValueToUpdate_TxtBox";
            this.RowValueToUpdate_TxtBox.Size = new System.Drawing.Size(358, 30);
            this.RowValueToUpdate_TxtBox.TabIndex = 9;
            // 
            // UpdateData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 348);
            this.Controls.Add(this.RowValueToUpdate_TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdatedColumn_TxtBox);
            this.Controls.Add(this.UpdateColumn_Label);
            this.Controls.Add(this.Instruction_Label);
            this.Controls.Add(this.ColumnToApply_Label);
            this.Controls.Add(this.WhereToApply_TxtBox);
            this.Controls.Add(this.UpdatedValue_TxtBox);
            this.Controls.Add(this.UpdatedValue_Label);
            this.Controls.Add(this.Submit_Button);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdateData_Form";
            this.Text = "Update Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label UpdatedValue_Label;
        private System.Windows.Forms.TextBox UpdatedValue_TxtBox;
        private System.Windows.Forms.TextBox WhereToApply_TxtBox;
        private System.Windows.Forms.Label ColumnToApply_Label;
        private System.Windows.Forms.Label Instruction_Label;
        private System.Windows.Forms.Label UpdateColumn_Label;
        private System.Windows.Forms.TextBox UpdatedColumn_TxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RowValueToUpdate_TxtBox;
    }
}