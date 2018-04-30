namespace SQLDatabaseApp
{
    partial class CreateUser_Form
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
            this.userName_Label = new System.Windows.Forms.Label();
            this.passWord_Label = new System.Windows.Forms.Label();
            this.userName_Txt = new System.Windows.Forms.TextBox();
            this.passWord_Txt = new System.Windows.Forms.TextBox();
            this.submit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(13, 16);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(95, 13);
            this.userName_Label.TabIndex = 0;
            this.userName_Label.Text = "Desired username:";
            // 
            // passWord_Label
            // 
            this.passWord_Label.AutoSize = true;
            this.passWord_Label.Location = new System.Drawing.Point(13, 42);
            this.passWord_Label.Name = "passWord_Label";
            this.passWord_Label.Size = new System.Drawing.Size(94, 13);
            this.passWord_Label.TabIndex = 1;
            this.passWord_Label.Text = "Desired password:";
            // 
            // userName_Txt
            // 
            this.userName_Txt.Location = new System.Drawing.Point(113, 9);
            this.userName_Txt.Name = "userName_Txt";
            this.userName_Txt.Size = new System.Drawing.Size(182, 20);
            this.userName_Txt.TabIndex = 2;
            // 
            // passWord_Txt
            // 
            this.passWord_Txt.Location = new System.Drawing.Point(113, 35);
            this.passWord_Txt.Name = "passWord_Txt";
            this.passWord_Txt.Size = new System.Drawing.Size(182, 20);
            this.passWord_Txt.TabIndex = 3;
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(16, 64);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(279, 32);
            this.submit_Button.TabIndex = 4;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // CreateUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 108);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.passWord_Txt);
            this.Controls.Add(this.userName_Txt);
            this.Controls.Add(this.passWord_Label);
            this.Controls.Add(this.userName_Label);
            this.Name = "CreateUser_Form";
            this.Text = "Create User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Label passWord_Label;
        private System.Windows.Forms.TextBox userName_Txt;
        private System.Windows.Forms.TextBox passWord_Txt;
        private System.Windows.Forms.Button submit_Button;
    }
}