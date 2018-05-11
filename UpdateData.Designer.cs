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
            this.ColumnToBeUpdated_TxtBox = new System.Windows.Forms.TextBox();
            this.RowToBeUpdated_TxtBox = new System.Windows.Forms.TextBox();
            this.ColumnThatAppliesUpdate_TxtBox = new System.Windows.Forms.TextBox();
            this.RowThatAppliesUpdate_TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(15, 130);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(403, 32);
            this.Submit_Button.TabIndex = 0;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // ColumnToBeUpdated_TxtBox
            // 
            this.ColumnToBeUpdated_TxtBox.Location = new System.Drawing.Point(273, 12);
            this.ColumnToBeUpdated_TxtBox.Name = "ColumnToBeUpdated_TxtBox";
            this.ColumnToBeUpdated_TxtBox.Size = new System.Drawing.Size(145, 20);
            this.ColumnToBeUpdated_TxtBox.TabIndex = 1;
            // 
            // RowToBeUpdated_TxtBox
            // 
            this.RowToBeUpdated_TxtBox.Location = new System.Drawing.Point(273, 38);
            this.RowToBeUpdated_TxtBox.Name = "RowToBeUpdated_TxtBox";
            this.RowToBeUpdated_TxtBox.Size = new System.Drawing.Size(145, 20);
            this.RowToBeUpdated_TxtBox.TabIndex = 2;
            // 
            // ColumnThatAppliesUpdate_TxtBox
            // 
            this.ColumnThatAppliesUpdate_TxtBox.Location = new System.Drawing.Point(273, 64);
            this.ColumnThatAppliesUpdate_TxtBox.Name = "ColumnThatAppliesUpdate_TxtBox";
            this.ColumnThatAppliesUpdate_TxtBox.Size = new System.Drawing.Size(145, 20);
            this.ColumnThatAppliesUpdate_TxtBox.TabIndex = 3;
            // 
            // RowThatAppliesUpdate_TxtBox
            // 
            this.RowThatAppliesUpdate_TxtBox.Location = new System.Drawing.Point(273, 90);
            this.RowThatAppliesUpdate_TxtBox.Name = "RowThatAppliesUpdate_TxtBox";
            this.RowThatAppliesUpdate_TxtBox.Size = new System.Drawing.Size(145, 20);
            this.RowThatAppliesUpdate_TxtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Column to be Updated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value of Row to be Updated";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Column of where Update is applied (Name, ID, e.t.c.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value of the row that applies Update";
            // 
            // UpdateData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowThatAppliesUpdate_TxtBox);
            this.Controls.Add(this.ColumnThatAppliesUpdate_TxtBox);
            this.Controls.Add(this.RowToBeUpdated_TxtBox);
            this.Controls.Add(this.ColumnToBeUpdated_TxtBox);
            this.Controls.Add(this.Submit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UpdateData_Form";
            this.Text = "Update Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.TextBox ColumnToBeUpdated_TxtBox;
        private System.Windows.Forms.TextBox RowToBeUpdated_TxtBox;
        private System.Windows.Forms.TextBox ColumnThatAppliesUpdate_TxtBox;
        private System.Windows.Forms.TextBox RowThatAppliesUpdate_TxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}