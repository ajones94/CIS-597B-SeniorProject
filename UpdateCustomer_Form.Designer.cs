namespace SQLDatabaseApp
{
    partial class UpdateData_Form
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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.UpdateColumn_Label = new System.Windows.Forms.Label();
            this.UpdateColumn_TxtBox = new System.Windows.Forms.TextBox();
            this.UpdateValue_TxtBox = new System.Windows.Forms.TextBox();
            this.UpdateValue_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(26, 177);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(670, 62);
            this.Submit_Button.TabIndex = 0;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // UpdateColumn_Label
            // 
            this.UpdateColumn_Label.AutoSize = true;
            this.UpdateColumn_Label.Location = new System.Drawing.Point(34, 75);
            this.UpdateColumn_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UpdateColumn_Label.Name = "UpdateColumn_Label";
            this.UpdateColumn_Label.Size = new System.Drawing.Size(147, 25);
            this.UpdateColumn_Label.TabIndex = 1;
            this.UpdateColumn_Label.Text = "Column Name";
            // 
            // UpdateColumn_TxtBox
            // 
            this.UpdateColumn_TxtBox.Location = new System.Drawing.Point(338, 69);
            this.UpdateColumn_TxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateColumn_TxtBox.Name = "UpdateColumn_TxtBox";
            this.UpdateColumn_TxtBox.Size = new System.Drawing.Size(358, 31);
            this.UpdateColumn_TxtBox.TabIndex = 2;
            // 
            // UpdateValue_TxtBox
            // 
            this.UpdateValue_TxtBox.Location = new System.Drawing.Point(338, 112);
            this.UpdateValue_TxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateValue_TxtBox.Name = "UpdateValue_TxtBox";
            this.UpdateValue_TxtBox.Size = new System.Drawing.Size(358, 31);
            this.UpdateValue_TxtBox.TabIndex = 3;
            // 
            // UpdateValue_Label
            // 
            this.UpdateValue_Label.AutoSize = true;
            this.UpdateValue_Label.Location = new System.Drawing.Point(34, 118);
            this.UpdateValue_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UpdateValue_Label.Name = "UpdateValue_Label";
            this.UpdateValue_Label.Size = new System.Drawing.Size(146, 25);
            this.UpdateValue_Label.TabIndex = 4;
            this.UpdateValue_Label.Text = "Column Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please provide a Column with a Value to be updated";
            // 
            // UpdateData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateValue_Label);
            this.Controls.Add(this.UpdateValue_TxtBox);
            this.Controls.Add(this.UpdateColumn_TxtBox);
            this.Controls.Add(this.UpdateColumn_Label);
            this.Controls.Add(this.Submit_Button);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdateData_Form";
            this.Text = "Update Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label UpdateColumn_Label;
        private System.Windows.Forms.TextBox UpdateColumn_TxtBox;
        private System.Windows.Forms.TextBox UpdateValue_TxtBox;
        private System.Windows.Forms.Label UpdateValue_Label;
        private System.Windows.Forms.Label label1;
    }
}