namespace SQLDatabaseApp
{
    partial class User_Access
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
            this.RemoveData = new System.Windows.Forms.Button();
            this.addData_button = new System.Windows.Forms.Button();
            this.ViewData = new System.Windows.Forms.Button();
            this.sqlData_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveData
            // 
            this.RemoveData.Location = new System.Drawing.Point(12, 41);
            this.RemoveData.Name = "RemoveData";
            this.RemoveData.Size = new System.Drawing.Size(90, 23);
            this.RemoveData.TabIndex = 1;
            this.RemoveData.Text = "Remove Data";
            this.RemoveData.UseVisualStyleBackColor = true;
            this.RemoveData.Click += new System.EventHandler(this.RemoveData_Click);
            // 
            // addData_button
            // 
            this.addData_button.Location = new System.Drawing.Point(12, 12);
            this.addData_button.Name = "addData_button";
            this.addData_button.Size = new System.Drawing.Size(90, 23);
            this.addData_button.TabIndex = 2;
            this.addData_button.Text = "Add Data";
            this.addData_button.UseVisualStyleBackColor = true;
            this.addData_button.Click += new System.EventHandler(this.addData_button_Click);
            // 
            // ViewData
            // 
            this.ViewData.Location = new System.Drawing.Point(12, 70);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(90, 23);
            this.ViewData.TabIndex = 3;
            this.ViewData.Text = "View Data";
            this.ViewData.UseVisualStyleBackColor = true;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
            // 
            // sqlData_list
            // 
            this.sqlData_list.FormattingEnabled = true;
            this.sqlData_list.Location = new System.Drawing.Point(109, 12);
            this.sqlData_list.Name = "sqlData_list";
            this.sqlData_list.Size = new System.Drawing.Size(403, 407);
            this.sqlData_list.TabIndex = 4;
            // 
            // User_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 444);
            this.Controls.Add(this.sqlData_list);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.addData_button);
            this.Controls.Add(this.RemoveData);
            this.Name = "User_Access";
            this.Text = "User Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveData;
        private System.Windows.Forms.Button addData_button;
        private System.Windows.Forms.Button ViewData;
        private System.Windows.Forms.ListBox sqlData_list;
    }
}