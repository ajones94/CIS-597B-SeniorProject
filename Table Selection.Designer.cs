namespace SQLDatabaseApp
{
    partial class TableSelection_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.TableName_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(8, 52);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(252, 30);
            this.Submit_Button.TabIndex = 0;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Name";
            // 
            // TableName_TxtBox
            // 
            this.TableName_TxtBox.Location = new System.Drawing.Point(73, 21);
            this.TableName_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableName_TxtBox.Multiline = true;
            this.TableName_TxtBox.Name = "TableName_TxtBox";
            this.TableName_TxtBox.Size = new System.Drawing.Size(190, 18);
            this.TableName_TxtBox.TabIndex = 2;
            // 
            // TableSelection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 95);
            this.Controls.Add(this.TableName_TxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TableSelection_Form";
            this.Text = "Table_Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableName_TxtBox;
    }
}