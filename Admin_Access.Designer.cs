namespace SQLDatabaseApp
{
    partial class Admin_Access
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
            this.CreateUser = new System.Windows.Forms.Button();
            this.CreateTable = new System.Windows.Forms.Button();
            this.AssignPriveleges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateUser
            // 
            this.CreateUser.Location = new System.Drawing.Point(12, 12);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(196, 32);
            this.CreateUser.TabIndex = 0;
            this.CreateUser.Text = "Create User";
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // CreateTable
            // 
            this.CreateTable.Location = new System.Drawing.Point(12, 50);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(196, 32);
            this.CreateTable.TabIndex = 1;
            this.CreateTable.Text = "Create Table";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // AssignPriveleges
            // 
            this.AssignPriveleges.Location = new System.Drawing.Point(12, 88);
            this.AssignPriveleges.Name = "AssignPriveleges";
            this.AssignPriveleges.Size = new System.Drawing.Size(196, 32);
            this.AssignPriveleges.TabIndex = 2;
            this.AssignPriveleges.Text = "Assign Priveleges";
            this.AssignPriveleges.UseVisualStyleBackColor = true;
            this.AssignPriveleges.Click += new System.EventHandler(this.AssignPriveleges_Click);
            // 
            // Admin_Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 137);
            this.Controls.Add(this.AssignPriveleges);
            this.Controls.Add(this.CreateTable);
            this.Controls.Add(this.CreateUser);
            this.Name = "Admin_Access";
            this.Text = "Admin Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.Button AssignPriveleges;
    }
}