namespace SQLDatabaseApp
{
    partial class CreateTable_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.table_Label = new System.Windows.Forms.Label();
            this.column_Label = new System.Windows.Forms.Label();
            this.dataType_label = new System.Windows.Forms.Label();
            this.datatype_txtBox = new System.Windows.Forms.TextBox();
            this.column_txtBox = new System.Windows.Forms.TextBox();
            this.table_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a valid table, column, and datatype";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(29, 223);
            this.submit_button.Margin = new System.Windows.Forms.Padding(6);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(468, 56);
            this.submit_button.TabIndex = 1;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // table_Label
            // 
            this.table_Label.AutoSize = true;
            this.table_Label.Location = new System.Drawing.Point(24, 85);
            this.table_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.table_Label.Name = "table_Label";
            this.table_Label.Size = new System.Drawing.Size(66, 25);
            this.table_Label.TabIndex = 2;
            this.table_Label.Text = "Table";
            // 
            // column_Label
            // 
            this.column_Label.AutoSize = true;
            this.column_Label.Location = new System.Drawing.Point(24, 128);
            this.column_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.column_Label.Name = "column_Label";
            this.column_Label.Size = new System.Drawing.Size(85, 25);
            this.column_Label.TabIndex = 3;
            this.column_Label.Text = "Column";
            // 
            // dataType_label
            // 
            this.dataType_label.AutoSize = true;
            this.dataType_label.Location = new System.Drawing.Point(24, 171);
            this.dataType_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dataType_label.Name = "dataType_label";
            this.dataType_label.Size = new System.Drawing.Size(98, 25);
            this.dataType_label.TabIndex = 4;
            this.dataType_label.Text = "Datatype";
            // 
            // datatype_txtBox
            // 
            this.datatype_txtBox.Location = new System.Drawing.Point(132, 165);
            this.datatype_txtBox.Margin = new System.Windows.Forms.Padding(6);
            this.datatype_txtBox.Multiline = true;
            this.datatype_txtBox.Name = "datatype_txtBox";
            this.datatype_txtBox.Size = new System.Drawing.Size(365, 31);
            this.datatype_txtBox.TabIndex = 8;
            // 
            // column_txtBox
            // 
            this.column_txtBox.Location = new System.Drawing.Point(132, 122);
            this.column_txtBox.Margin = new System.Windows.Forms.Padding(6);
            this.column_txtBox.Multiline = true;
            this.column_txtBox.Name = "column_txtBox";
            this.column_txtBox.Size = new System.Drawing.Size(365, 31);
            this.column_txtBox.TabIndex = 7;
            // 
            // table_txtBox
            // 
            this.table_txtBox.Location = new System.Drawing.Point(132, 79);
            this.table_txtBox.Margin = new System.Windows.Forms.Padding(6);
            this.table_txtBox.Multiline = true;
            this.table_txtBox.Name = "table_txtBox";
            this.table_txtBox.Size = new System.Drawing.Size(365, 31);
            this.table_txtBox.TabIndex = 6;
            // 
            // CreateTable_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 309);
            this.Controls.Add(this.datatype_txtBox);
            this.Controls.Add(this.column_txtBox);
            this.Controls.Add(this.table_txtBox);
            this.Controls.Add(this.dataType_label);
            this.Controls.Add(this.column_Label);
            this.Controls.Add(this.table_Label);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTable_Form";
            this.Text = "Create Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label table_Label;
        private System.Windows.Forms.Label column_Label;
        private System.Windows.Forms.Label dataType_label;
        private System.Windows.Forms.TextBox datatype_txtBox;
        private System.Windows.Forms.TextBox column_txtBox;
        private System.Windows.Forms.TextBox table_txtBox;
    }
}