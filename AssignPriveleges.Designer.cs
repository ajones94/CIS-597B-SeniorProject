namespace SQLDatabaseApp
{
    partial class AssignPriveleges_Form
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
            this.submit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.permission_TxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_TxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.database_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(9, 80);
            this.submit_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(267, 26);
            this.submit_Button.TabIndex = 0;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permission";
            // 
            // permission_TxtBox
            // 
            this.permission_TxtBox.Location = new System.Drawing.Point(76, 11);
            this.permission_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.permission_TxtBox.Multiline = true;
            this.permission_TxtBox.Name = "permission_TxtBox";
            this.permission_TxtBox.Size = new System.Drawing.Size(200, 19);
            this.permission_TxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // user_TxtBox
            // 
            this.user_TxtBox.Location = new System.Drawing.Point(76, 34);
            this.user_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user_TxtBox.Multiline = true;
            this.user_TxtBox.Name = "user_TxtBox";
            this.user_TxtBox.Size = new System.Drawing.Size(200, 19);
            this.user_TxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database";
            // 
            // database_TxtBox
            // 
            this.database_TxtBox.Location = new System.Drawing.Point(76, 57);
            this.database_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.database_TxtBox.Multiline = true;
            this.database_TxtBox.Name = "database_TxtBox";
            this.database_TxtBox.Size = new System.Drawing.Size(200, 19);
            this.database_TxtBox.TabIndex = 6;
            // 
            // AssignPriveleges_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 113);
            this.Controls.Add(this.database_TxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.permission_TxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignPriveleges_Form";
            this.Text = "Assign Priveleges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox permission_TxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_TxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox database_TxtBox;
    }
}