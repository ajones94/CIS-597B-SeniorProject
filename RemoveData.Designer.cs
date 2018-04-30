namespace SQLDatabaseApp
{
    partial class delete_Form
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
            this.table_Label = new System.Windows.Forms.Label();
            this.column_Label = new System.Windows.Forms.Label();
            this.value_Label = new System.Windows.Forms.Label();
            this.table_txtBox = new System.Windows.Forms.TextBox();
            this.column_txtBox = new System.Windows.Forms.TextBox();
            this.data_txtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table_Label
            // 
            this.table_Label.AutoSize = true;
            this.table_Label.Location = new System.Drawing.Point(14, 44);
            this.table_Label.Name = "table_Label";
            this.table_Label.Size = new System.Drawing.Size(34, 13);
            this.table_Label.TabIndex = 0;
            this.table_Label.Text = "Table";
            // 
            // column_Label
            // 
            this.column_Label.AutoSize = true;
            this.column_Label.Location = new System.Drawing.Point(14, 70);
            this.column_Label.Name = "column_Label";
            this.column_Label.Size = new System.Drawing.Size(42, 13);
            this.column_Label.TabIndex = 1;
            this.column_Label.Text = "Column";
            // 
            // value_Label
            // 
            this.value_Label.AutoSize = true;
            this.value_Label.Location = new System.Drawing.Point(14, 100);
            this.value_Label.Name = "value_Label";
            this.value_Label.Size = new System.Drawing.Size(30, 13);
            this.value_Label.TabIndex = 2;
            this.value_Label.Text = "Data";
            // 
            // table_txtBox
            // 
            this.table_txtBox.Location = new System.Drawing.Point(74, 37);
            this.table_txtBox.Name = "table_txtBox";
            this.table_txtBox.Size = new System.Drawing.Size(100, 20);
            this.table_txtBox.TabIndex = 3;
            // 
            // column_txtBox
            // 
            this.column_txtBox.Location = new System.Drawing.Point(74, 63);
            this.column_txtBox.Name = "column_txtBox";
            this.column_txtBox.Size = new System.Drawing.Size(100, 20);
            this.column_txtBox.TabIndex = 4;
            // 
            // data_txtBox
            // 
            this.data_txtBox.Location = new System.Drawing.Point(74, 93);
            this.data_txtBox.Name = "data_txtBox";
            this.data_txtBox.Size = new System.Drawing.Size(100, 20);
            this.data_txtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "What would you like to remove? ";
            // 
            // submit_Button
            // 
            this.submit_Button.Location = new System.Drawing.Point(17, 131);
            this.submit_Button.Name = "submit_Button";
            this.submit_Button.Size = new System.Drawing.Size(157, 32);
            this.submit_Button.TabIndex = 7;
            this.submit_Button.Text = "Submit";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(this.submit_Button_Click);
            // 
            // delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 175);
            this.Controls.Add(this.submit_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_txtBox);
            this.Controls.Add(this.column_txtBox);
            this.Controls.Add(this.table_txtBox);
            this.Controls.Add(this.value_Label);
            this.Controls.Add(this.column_Label);
            this.Controls.Add(this.table_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "delete_Form";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_Label;
        private System.Windows.Forms.Label column_Label;
        private System.Windows.Forms.Label value_Label;
        private System.Windows.Forms.TextBox table_txtBox;
        private System.Windows.Forms.TextBox column_txtBox;
        private System.Windows.Forms.TextBox data_txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit_Button;
    }
}