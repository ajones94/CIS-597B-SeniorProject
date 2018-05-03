namespace SQLDatabaseApp
{
    partial class DataAccess_Form
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
            this.RemoveCustomer_Button = new System.Windows.Forms.Button();
            this.ViewCustomers_Button = new System.Windows.Forms.Button();
            this.updateCustomer_button = new System.Windows.Forms.Button();
            this.AddCustomer_Button = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveCustomer_Button
            // 
            this.RemoveCustomer_Button.Location = new System.Drawing.Point(12, 50);
            this.RemoveCustomer_Button.Name = "RemoveCustomer_Button";
            this.RemoveCustomer_Button.Size = new System.Drawing.Size(89, 41);
            this.RemoveCustomer_Button.TabIndex = 1;
            this.RemoveCustomer_Button.Text = "Remove Customer";
            this.RemoveCustomer_Button.UseVisualStyleBackColor = true;
            this.RemoveCustomer_Button.Click += new System.EventHandler(this.RemoveCustomer_Button_Click);
            // 
            // ViewCustomers_Button
            // 
            this.ViewCustomers_Button.Location = new System.Drawing.Point(12, 97);
            this.ViewCustomers_Button.Name = "ViewCustomers_Button";
            this.ViewCustomers_Button.Size = new System.Drawing.Size(89, 40);
            this.ViewCustomers_Button.TabIndex = 3;
            this.ViewCustomers_Button.Text = "View Customers";
            this.ViewCustomers_Button.UseVisualStyleBackColor = true;
            this.ViewCustomers_Button.Click += new System.EventHandler(this.ViewCustomers_Button_Click);
            // 
            // updateCustomer_button
            // 
            this.updateCustomer_button.Location = new System.Drawing.Point(12, 143);
            this.updateCustomer_button.Name = "updateCustomer_button";
            this.updateCustomer_button.Size = new System.Drawing.Size(89, 42);
            this.updateCustomer_button.TabIndex = 5;
            this.updateCustomer_button.Text = "Update Customer";
            this.updateCustomer_button.UseVisualStyleBackColor = true;
            this.updateCustomer_button.Click += new System.EventHandler(this.updateCustomer_button_Click);
            // 
            // AddCustomer_Button
            // 
            this.AddCustomer_Button.Location = new System.Drawing.Point(12, 12);
            this.AddCustomer_Button.Name = "AddCustomer_Button";
            this.AddCustomer_Button.Size = new System.Drawing.Size(89, 32);
            this.AddCustomer_Button.TabIndex = 6;
            this.AddCustomer_Button.Text = "Add Customer";
            this.AddCustomer_Button.UseVisualStyleBackColor = true;
            this.AddCustomer_Button.Click += new System.EventHandler(this.AddCustomer_Button_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(115, 12);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(397, 420);
            this.CustomerList.TabIndex = 7;
            // 
            // DataAccess_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 444);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.AddCustomer_Button);
            this.Controls.Add(this.updateCustomer_button);
            this.Controls.Add(this.ViewCustomers_Button);
            this.Controls.Add(this.RemoveCustomer_Button);
            this.Name = "DataAccess_Form";
            this.Text = "Data Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveCustomer_Button;
        private System.Windows.Forms.Button AddCustomer_Button;
        private System.Windows.Forms.Button ViewCustomers_Button;
        private System.Windows.Forms.Button updateCustomer_button;
        private System.Windows.Forms.ListBox CustomerList;
    }
}