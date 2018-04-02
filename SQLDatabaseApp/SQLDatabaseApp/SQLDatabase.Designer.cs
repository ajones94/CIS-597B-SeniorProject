namespace SQLDatabaseApp
{
    partial class SQLDatabase
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
            this.user_login_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.database_label = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.database_txtbox = new System.Windows.Forms.TextBox();
            this.admin_login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_login_button
            // 
            this.user_login_button.Location = new System.Drawing.Point(11, 104);
            this.user_login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user_login_button.Name = "user_login_button";
            this.user_login_button.Size = new System.Drawing.Size(80, 32);
            this.user_login_button.TabIndex = 0;
            this.user_login_button.Text = "User Login";
            this.user_login_button.UseVisualStyleBackColor = true;
            this.user_login_button.Click += new System.EventHandler(this.user_login_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(8, 25);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(8, 49);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // database_label
            // 
            this.database_label.AutoSize = true;
            this.database_label.Location = new System.Drawing.Point(8, 73);
            this.database_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.database_label.Name = "database_label";
            this.database_label.Size = new System.Drawing.Size(56, 13);
            this.database_label.TabIndex = 3;
            this.database_label.Text = "Database:";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(81, 18);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(130, 20);
            this.username_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(81, 42);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(130, 20);
            this.password_txtbox.TabIndex = 5;
            // 
            // database_txtbox
            // 
            this.database_txtbox.Location = new System.Drawing.Point(81, 66);
            this.database_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.database_txtbox.Name = "database_txtbox";
            this.database_txtbox.Size = new System.Drawing.Size(130, 20);
            this.database_txtbox.TabIndex = 6;
            // 
            // admin_login_button
            // 
            this.admin_login_button.Location = new System.Drawing.Point(111, 104);
            this.admin_login_button.Name = "admin_login_button";
            this.admin_login_button.Size = new System.Drawing.Size(100, 32);
            this.admin_login_button.TabIndex = 7;
            this.admin_login_button.Text = "Admin Login";
            this.admin_login_button.UseVisualStyleBackColor = true;
            // 
            // SQLDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 148);
            this.Controls.Add(this.admin_login_button);
            this.Controls.Add(this.database_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.database_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.user_login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SQLDatabase";
            this.Text = "Database Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button user_login_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label database_label;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox database_txtbox;
        private System.Windows.Forms.Button admin_login_button;
    }
}

