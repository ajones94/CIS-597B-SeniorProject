namespace SQLDatabaseApp
{
    partial class RemoveCustomer_Form
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
            this.table_Label = new System.Windows.Forms.Label();
            this.RemoveCustomer_TxtBox = new System.Windows.Forms.TextBox();
            this.RemoveCustomer_Label = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table_Label
            // 
            this.table_Label.AutoSize = true;
            this.table_Label.Location = new System.Drawing.Point(14, 44);
            this.table_Label.Name = "table_Label";
            this.table_Label.Size = new System.Drawing.Size(104, 13);
            this.table_Label.TabIndex = 0;
            this.table_Label.Text = "Customer to remove ";
            // 
            // RemoveCustomer_TxtBox
            // 
            this.RemoveCustomer_TxtBox.Location = new System.Drawing.Point(124, 37);
            this.RemoveCustomer_TxtBox.Name = "RemoveCustomer_TxtBox";
            this.RemoveCustomer_TxtBox.Size = new System.Drawing.Size(191, 20);
            this.RemoveCustomer_TxtBox.TabIndex = 3;
            // 
            // RemoveCustomer_Label
            // 
            this.RemoveCustomer_Label.AutoSize = true;
            this.RemoveCustomer_Label.Location = new System.Drawing.Point(80, 9);
            this.RemoveCustomer_Label.Name = "RemoveCustomer_Label";
            this.RemoveCustomer_Label.Size = new System.Drawing.Size(158, 13);
            this.RemoveCustomer_Label.TabIndex = 6;
            this.RemoveCustomer_Label.Text = "Customer to Remove (By Name)";
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(17, 64);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(298, 32);
            this.submit_Button.TabIndex = 7;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // RemoveCustomer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 108);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.RemoveCustomer_Label);
            this.Controls.Add(this.RemoveCustomer_TxtBox);
            this.Controls.Add(this.table_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RemoveCustomer_Form";
            this.Text = "Remove Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_Label;
        private System.Windows.Forms.TextBox RemoveCustomer_TxtBox;
        private System.Windows.Forms.Label RemoveCustomer_Label;
        private System.Windows.Forms.Button submit_Button;
    }
}