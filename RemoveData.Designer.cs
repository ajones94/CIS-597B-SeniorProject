namespace SQLDatabaseApp
{
    partial class RemoveData_Form
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
            this.DataRemoval_Label = new System.Windows.Forms.Label();
            this.ColumnName_TxtBox = new System.Windows.Forms.TextBox();
            this.RemoveCustomer_Label = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.ColumnValue_Label = new System.Windows.Forms.Label();
            this.ColumnValue_Txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DataRemoval_Label
            // 
            this.DataRemoval_Label.AutoSize = true;
            this.DataRemoval_Label.Location = new System.Drawing.Point(28, 85);
            this.DataRemoval_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DataRemoval_Label.Name = "DataRemoval_Label";
            this.DataRemoval_Label.Size = new System.Drawing.Size(147, 25);
            this.DataRemoval_Label.TabIndex = 0;
            this.DataRemoval_Label.Text = "Column Name";
            // 
            // ColumnName_TxtBox
            // 
            this.ColumnName_TxtBox.Location = new System.Drawing.Point(248, 71);
            this.ColumnName_TxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.ColumnName_TxtBox.Name = "ColumnName_TxtBox";
            this.ColumnName_TxtBox.Size = new System.Drawing.Size(378, 31);
            this.ColumnName_TxtBox.TabIndex = 3;
            // 
            // RemoveCustomer_Label
            // 
            this.RemoveCustomer_Label.AutoSize = true;
            this.RemoveCustomer_Label.Location = new System.Drawing.Point(76, 22);
            this.RemoveCustomer_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RemoveCustomer_Label.Name = "RemoveCustomer_Label";
            this.RemoveCustomer_Label.Size = new System.Drawing.Size(518, 25);
            this.RemoveCustomer_Label.TabIndex = 6;
            this.RemoveCustomer_Label.Text = "Please provide a Column with a Value to be removed";
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(37, 177);
            this.submit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(596, 62);
            this.submit_Button.TabIndex = 7;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // ColumnValue_Label
            // 
            this.ColumnValue_Label.AutoSize = true;
            this.ColumnValue_Label.Location = new System.Drawing.Point(28, 126);
            this.ColumnValue_Label.Name = "ColumnValue_Label";
            this.ColumnValue_Label.Size = new System.Drawing.Size(146, 25);
            this.ColumnValue_Label.TabIndex = 8;
            this.ColumnValue_Label.Text = "Column Value";
            // 
            // ColumnValue_Txtbox
            // 
            this.ColumnValue_Txtbox.Location = new System.Drawing.Point(248, 120);
            this.ColumnValue_Txtbox.Multiline = true;
            this.ColumnValue_Txtbox.Name = "ColumnValue_Txtbox";
            this.ColumnValue_Txtbox.Size = new System.Drawing.Size(378, 31);
            this.ColumnValue_Txtbox.TabIndex = 9;
            // 
            // RemoveData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 254);
            this.Controls.Add(this.ColumnValue_Txtbox);
            this.Controls.Add(this.ColumnValue_Label);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.RemoveCustomer_Label);
            this.Controls.Add(this.ColumnName_TxtBox);
            this.Controls.Add(this.DataRemoval_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RemoveData_Form";
            this.Text = "Remove Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataRemoval_Label;
        private System.Windows.Forms.TextBox ColumnName_TxtBox;
        private System.Windows.Forms.Label RemoveCustomer_Label;
        private System.Windows.Forms.Button submit_Button;
        private System.Windows.Forms.Label ColumnValue_Label;
        private System.Windows.Forms.TextBox ColumnValue_Txtbox;
    }
}