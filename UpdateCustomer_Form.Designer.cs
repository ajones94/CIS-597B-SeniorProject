namespace SQLDatabaseApp
{
    partial class UpdateCustomer_Form
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
            this.CustomerName_Label = new System.Windows.Forms.Label();
            this.CustomerName_TxtBox = new System.Windows.Forms.TextBox();
            this.UpdateCustomer_TxtBox = new System.Windows.Forms.TextBox();
            this.UpdateCustomer_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(15, 64);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(335, 32);
            this.Submit_Button.TabIndex = 0;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // CustomerName_Label
            // 
            this.CustomerName_Label.AutoSize = true;
            this.CustomerName_Label.Location = new System.Drawing.Point(12, 9);
            this.CustomerName_Label.Name = "CustomerName_Label";
            this.CustomerName_Label.Size = new System.Drawing.Size(82, 13);
            this.CustomerName_Label.TabIndex = 1;
            this.CustomerName_Label.Text = "Customer Name";
            // 
            // CustomerName_TxtBox
            // 
            this.CustomerName_TxtBox.Location = new System.Drawing.Point(169, 2);
            this.CustomerName_TxtBox.Name = "CustomerName_TxtBox";
            this.CustomerName_TxtBox.Size = new System.Drawing.Size(181, 20);
            this.CustomerName_TxtBox.TabIndex = 2;
            // 
            // UpdateCustomer_TxtBox
            // 
            this.UpdateCustomer_TxtBox.Location = new System.Drawing.Point(169, 28);
            this.UpdateCustomer_TxtBox.Name = "UpdateCustomer_TxtBox";
            this.UpdateCustomer_TxtBox.Size = new System.Drawing.Size(181, 20);
            this.UpdateCustomer_TxtBox.TabIndex = 3;
            // 
            // UpdateCustomer_Label
            // 
            this.UpdateCustomer_Label.AutoSize = true;
            this.UpdateCustomer_Label.Location = new System.Drawing.Point(12, 35);
            this.UpdateCustomer_Label.Name = "UpdateCustomer_Label";
            this.UpdateCustomer_Label.Size = new System.Drawing.Size(151, 13);
            this.UpdateCustomer_Label.TabIndex = 4;
            this.UpdateCustomer_Label.Text = "Update Customer Order Status";
            // 
            // UpdateCustomer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 105);
            this.Controls.Add(this.UpdateCustomer_Label);
            this.Controls.Add(this.UpdateCustomer_TxtBox);
            this.Controls.Add(this.CustomerName_TxtBox);
            this.Controls.Add(this.CustomerName_Label);
            this.Controls.Add(this.Submit_Button);
            this.Name = "UpdateCustomer_Form";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label CustomerName_Label;
        private System.Windows.Forms.TextBox CustomerName_TxtBox;
        private System.Windows.Forms.TextBox UpdateCustomer_TxtBox;
        private System.Windows.Forms.Label UpdateCustomer_Label;
    }
}