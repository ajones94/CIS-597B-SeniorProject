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
            this.RemoveData_Button = new System.Windows.Forms.Button();
            this.ViewData_Button = new System.Windows.Forms.Button();
            this.UpdateData_button = new System.Windows.Forms.Button();
            this.AddData_Button = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveData_Button
            // 
            this.RemoveData_Button.Location = new System.Drawing.Point(24, 96);
            this.RemoveData_Button.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveData_Button.Name = "RemoveData_Button";
            this.RemoveData_Button.Size = new System.Drawing.Size(178, 79);
            this.RemoveData_Button.TabIndex = 1;
            this.RemoveData_Button.Text = "Remove Data";
            this.RemoveData_Button.UseVisualStyleBackColor = true;
            this.RemoveData_Button.Click += new System.EventHandler(this.RemoveCustomer_Button_Click);
            // 
            // ViewData_Button
            // 
            this.ViewData_Button.Location = new System.Drawing.Point(24, 187);
            this.ViewData_Button.Margin = new System.Windows.Forms.Padding(6);
            this.ViewData_Button.Name = "ViewData_Button";
            this.ViewData_Button.Size = new System.Drawing.Size(178, 77);
            this.ViewData_Button.TabIndex = 3;
            this.ViewData_Button.Text = "View Data";
            this.ViewData_Button.UseVisualStyleBackColor = true;
            this.ViewData_Button.Click += new System.EventHandler(this.ViewCustomers_Button_Click);
            // 
            // UpdateData_button
            // 
            this.UpdateData_button.Location = new System.Drawing.Point(24, 275);
            this.UpdateData_button.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateData_button.Name = "UpdateData_button";
            this.UpdateData_button.Size = new System.Drawing.Size(178, 81);
            this.UpdateData_button.TabIndex = 5;
            this.UpdateData_button.Text = "Update Data";
            this.UpdateData_button.UseVisualStyleBackColor = true;
            this.UpdateData_button.Click += new System.EventHandler(this.updateCustomer_button_Click);
            // 
            // AddData_Button
            // 
            this.AddData_Button.Location = new System.Drawing.Point(24, 23);
            this.AddData_Button.Margin = new System.Windows.Forms.Padding(6);
            this.AddData_Button.Name = "AddData_Button";
            this.AddData_Button.Size = new System.Drawing.Size(178, 62);
            this.AddData_Button.TabIndex = 6;
            this.AddData_Button.Text = "Add Data";
            this.AddData_Button.UseVisualStyleBackColor = true;
            this.AddData_Button.Click += new System.EventHandler(this.AddCustomer_Button_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 25;
            this.CustomerList.Location = new System.Drawing.Point(230, 23);
            this.CustomerList.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(790, 804);
            this.CustomerList.TabIndex = 7;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(24, 767);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(178, 60);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // DataAccess_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 854);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.AddData_Button);
            this.Controls.Add(this.UpdateData_button);
            this.Controls.Add(this.ViewData_Button);
            this.Controls.Add(this.RemoveData_Button);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DataAccess_Form";
            this.Text = "Data Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveData_Button;
        private System.Windows.Forms.Button AddData_Button;
        private System.Windows.Forms.Button ViewData_Button;
        private System.Windows.Forms.Button UpdateData_button;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Button Exit_Button;
    }
}