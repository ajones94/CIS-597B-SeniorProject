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
            this.Login_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Database_Label = new System.Windows.Forms.Label();
            this.Username_TxtBox = new System.Windows.Forms.TextBox();
            this.Database_TxtBox = new System.Windows.Forms.TextBox();
            this.Password_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Enabled = false;
            this.Login_Button.Location = new System.Drawing.Point(30, 202);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(180, 54);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(370, 202);
            this.exit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(180, 54);
            this.exit_Button.TabIndex = 9;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(24, 65);
            this.Username_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(110, 25);
            this.Username_Label.TabIndex = 10;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(24, 149);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(106, 25);
            this.Password_Label.TabIndex = 11;
            this.Password_Label.Text = "Password";
            // 
            // Database_Label
            // 
            this.Database_Label.AutoSize = true;
            this.Database_Label.Location = new System.Drawing.Point(24, 109);
            this.Database_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Database_Label.Name = "Database_Label";
            this.Database_Label.Size = new System.Drawing.Size(104, 25);
            this.Database_Label.TabIndex = 15;
            this.Database_Label.Text = "Database";
            // 
            // Username_TxtBox
            // 
            this.Username_TxtBox.Location = new System.Drawing.Point(164, 56);
            this.Username_TxtBox.Multiline = true;
            this.Username_TxtBox.Name = "Username_TxtBox";
            this.Username_TxtBox.Size = new System.Drawing.Size(382, 34);
            this.Username_TxtBox.TabIndex = 16;
            // 
            // Database_TxtBox
            // 
            this.Database_TxtBox.Location = new System.Drawing.Point(164, 96);
            this.Database_TxtBox.Multiline = true;
            this.Database_TxtBox.Name = "Database_TxtBox";
            this.Database_TxtBox.Size = new System.Drawing.Size(382, 38);
            this.Database_TxtBox.TabIndex = 17;
            // 
            // Password_TxtBox
            // 
            this.Password_TxtBox.Location = new System.Drawing.Point(164, 140);
            this.Password_TxtBox.Multiline = true;
            this.Password_TxtBox.Name = "Password_TxtBox";
            this.Password_TxtBox.Size = new System.Drawing.Size(382, 34);
            this.Password_TxtBox.TabIndex = 18;
            this.Password_TxtBox.TextChanged += new System.EventHandler(this.Password_TxtBox_TextChanged);
            // 
            // SQLDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 273);
            this.Controls.Add(this.Password_TxtBox);
            this.Controls.Add(this.Database_TxtBox);
            this.Controls.Add(this.Username_TxtBox);
            this.Controls.Add(this.Database_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.Login_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SQLDatabase";
            this.Text = "Database Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Database_Label;
        private System.Windows.Forms.TextBox Username_TxtBox;
        private System.Windows.Forms.TextBox Database_TxtBox;
        private System.Windows.Forms.TextBox Password_TxtBox;
    }
}

