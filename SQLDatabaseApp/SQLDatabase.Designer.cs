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
            this.connect_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.database_label = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.database_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(121, 225);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(161, 62);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(13, 40);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(116, 25);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(13, 93);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(112, 25);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password:";
            // 
            // database_label
            // 
            this.database_label.AutoSize = true;
            this.database_label.Location = new System.Drawing.Point(13, 153);
            this.database_label.Name = "database_label";
            this.database_label.Size = new System.Drawing.Size(110, 25);
            this.database_label.TabIndex = 3;
            this.database_label.Text = "Database:";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(162, 34);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(256, 31);
            this.username_txtbox.TabIndex = 4;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(162, 87);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(256, 31);
            this.password_txtbox.TabIndex = 5;
            // 
            // database_txtbox
            // 
            this.database_txtbox.Location = new System.Drawing.Point(162, 147);
            this.database_txtbox.Name = "database_txtbox";
            this.database_txtbox.Size = new System.Drawing.Size(256, 31);
            this.database_txtbox.TabIndex = 6;
            // 
            // SQLDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.database_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.database_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.connect_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SQLDatabase";
            this.Text = "Database Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label database_label;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox database_txtbox;
    }
}

