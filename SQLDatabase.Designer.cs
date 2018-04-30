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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.RadioButton();
            this.admin_button = new System.Windows.Forms.RadioButton();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(11, 18);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(11, 42);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(84, 11);
            this.username_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(130, 20);
            this.username_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(84, 35);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(130, 20);
            this.password_txtbox.TabIndex = 5;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Enabled = false;
            this.login_button.Location = new System.Drawing.Point(12, 124);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(90, 28);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // user_button
            // 
            this.user_button.AutoSize = true;
            this.user_button.Location = new System.Drawing.Point(84, 71);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(47, 17);
            this.user_button.TabIndex = 7;
            this.user_button.TabStop = true;
            this.user_button.Text = "User";
            this.user_button.UseVisualStyleBackColor = true;
            // 
            // admin_button
            // 
            this.admin_button.AutoSize = true;
            this.admin_button.Location = new System.Drawing.Point(84, 94);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(54, 17);
            this.admin_button.TabIndex = 8;
            this.admin_button.TabStop = true;
            this.admin_button.Text = "Admin";
            this.admin_button.UseVisualStyleBackColor = true;
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(123, 124);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(90, 28);
            this.exit_Button.TabIndex = 9;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // SQLDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 164);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SQLDatabase";
            this.Text = "Database Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.RadioButton user_button;
        private System.Windows.Forms.RadioButton admin_button;
        private System.Windows.Forms.Button exit_Button;
    }
}

