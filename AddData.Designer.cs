namespace SQLDatabaseApp
{
    partial class AddData_Form
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
            this.CustomerName_Label = new System.Windows.Forms.Label();
            this.Column1_TxtBox = new System.Windows.Forms.TextBox();
            this.Column2_TxtBox = new System.Windows.Forms.TextBox();
            this.CustomerID_Label = new System.Windows.Forms.Label();
            this.instruction_Label = new System.Windows.Forms.Label();
            this.insert_Submit = new System.Windows.Forms.Button();
            this.CustomerOrder_Label = new System.Windows.Forms.Label();
            this.Column3_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerName_Label
            // 
            this.CustomerName_Label.AutoSize = true;
            this.CustomerName_Label.Location = new System.Drawing.Point(12, 38);
            this.CustomerName_Label.Name = "CustomerName_Label";
            this.CustomerName_Label.Size = new System.Drawing.Size(91, 13);
            this.CustomerName_Label.TabIndex = 0;
            this.CustomerName_Label.Text = "Data for column 1";
            // 
            // Column1_TxtBox
            // 
            this.Column1_TxtBox.Location = new System.Drawing.Point(111, 31);
            this.Column1_TxtBox.Name = "Column1_TxtBox";
            this.Column1_TxtBox.Size = new System.Drawing.Size(305, 20);
            this.Column1_TxtBox.TabIndex = 1;
            // 
            // Column2_TxtBox
            // 
            this.Column2_TxtBox.Location = new System.Drawing.Point(111, 57);
            this.Column2_TxtBox.Name = "Column2_TxtBox";
            this.Column2_TxtBox.Size = new System.Drawing.Size(305, 20);
            this.Column2_TxtBox.TabIndex = 2;
            // 
            // CustomerID_Label
            // 
            this.CustomerID_Label.AutoSize = true;
            this.CustomerID_Label.Location = new System.Drawing.Point(14, 64);
            this.CustomerID_Label.Name = "CustomerID_Label";
            this.CustomerID_Label.Size = new System.Drawing.Size(91, 13);
            this.CustomerID_Label.TabIndex = 3;
            this.CustomerID_Label.Text = "Data for column 2";
            // 
            // instruction_Label
            // 
            this.instruction_Label.AutoSize = true;
            this.instruction_Label.Location = new System.Drawing.Point(12, 9);
            this.instruction_Label.Name = "instruction_Label";
            this.instruction_Label.Size = new System.Drawing.Size(404, 13);
            this.instruction_Label.TabIndex = 6;
            this.instruction_Label.Text = "Please provide all necessary information for column data (Must Not Be Empty or Nu" +
    "ll)";
            // 
            // insert_Submit
            // 
            this.insert_Submit.Location = new System.Drawing.Point(17, 109);
            this.insert_Submit.Name = "insert_Submit";
            this.insert_Submit.Size = new System.Drawing.Size(399, 30);
            this.insert_Submit.TabIndex = 7;
            this.insert_Submit.Text = "Submit";
            this.insert_Submit.UseVisualStyleBackColor = true;
            this.insert_Submit.Click += new System.EventHandler(this.insert_Submit_Click);
            // 
            // CustomerOrder_Label
            // 
            this.CustomerOrder_Label.AutoSize = true;
            this.CustomerOrder_Label.Location = new System.Drawing.Point(14, 90);
            this.CustomerOrder_Label.Name = "CustomerOrder_Label";
            this.CustomerOrder_Label.Size = new System.Drawing.Size(91, 13);
            this.CustomerOrder_Label.TabIndex = 8;
            this.CustomerOrder_Label.Text = "Data for column 3";
            // 
            // Column3_TxtBox
            // 
            this.Column3_TxtBox.Location = new System.Drawing.Point(111, 83);
            this.Column3_TxtBox.Name = "Column3_TxtBox";
            this.Column3_TxtBox.Size = new System.Drawing.Size(305, 20);
            this.Column3_TxtBox.TabIndex = 9;
            // 
            // AddData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 151);
            this.Controls.Add(this.Column3_TxtBox);
            this.Controls.Add(this.CustomerOrder_Label);
            this.Controls.Add(this.insert_Submit);
            this.Controls.Add(this.instruction_Label);
            this.Controls.Add(this.CustomerID_Label);
            this.Controls.Add(this.Column2_TxtBox);
            this.Controls.Add(this.Column1_TxtBox);
            this.Controls.Add(this.CustomerName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddData_Form";
            this.Text = "Add Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName_Label;
        private System.Windows.Forms.TextBox Column1_TxtBox;
        private System.Windows.Forms.TextBox Column2_TxtBox;
        private System.Windows.Forms.Label CustomerID_Label;
        private System.Windows.Forms.Label instruction_Label;
        private System.Windows.Forms.Button insert_Submit;
        private System.Windows.Forms.Label CustomerOrder_Label;
        private System.Windows.Forms.TextBox Column3_TxtBox;
    }
}