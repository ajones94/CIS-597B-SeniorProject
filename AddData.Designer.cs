namespace SQLDatabaseApp
{
    partial class Insert_Form
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
            this.inserttable_label = new System.Windows.Forms.Label();
            this.tabletxt_Insert = new System.Windows.Forms.TextBox();
            this.columntxt_Insert = new System.Windows.Forms.TextBox();
            this.tablecolumn_Label = new System.Windows.Forms.Label();
            this.table_Value = new System.Windows.Forms.Label();
            this.valuetxt_Insert = new System.Windows.Forms.TextBox();
            this.instruction_Label = new System.Windows.Forms.Label();
            this.insert_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inserttable_label
            // 
            this.inserttable_label.AutoSize = true;
            this.inserttable_label.Location = new System.Drawing.Point(12, 38);
            this.inserttable_label.Name = "inserttable_label";
            this.inserttable_label.Size = new System.Drawing.Size(65, 13);
            this.inserttable_label.TabIndex = 0;
            this.inserttable_label.Text = "Table Name";
            // 
            // tabletxt_Insert
            // 
            this.tabletxt_Insert.Location = new System.Drawing.Point(90, 31);
            this.tabletxt_Insert.Name = "tabletxt_Insert";
            this.tabletxt_Insert.Size = new System.Drawing.Size(182, 20);
            this.tabletxt_Insert.TabIndex = 1;
            // 
            // columntxt_Insert
            // 
            this.columntxt_Insert.Location = new System.Drawing.Point(90, 57);
            this.columntxt_Insert.Name = "columntxt_Insert";
            this.columntxt_Insert.Size = new System.Drawing.Size(182, 20);
            this.columntxt_Insert.TabIndex = 2;
            // 
            // tablecolumn_Label
            // 
            this.tablecolumn_Label.AutoSize = true;
            this.tablecolumn_Label.Location = new System.Drawing.Point(12, 64);
            this.tablecolumn_Label.Name = "tablecolumn_Label";
            this.tablecolumn_Label.Size = new System.Drawing.Size(72, 13);
            this.tablecolumn_Label.TabIndex = 3;
            this.tablecolumn_Label.Text = "Table Column";
            // 
            // table_Value
            // 
            this.table_Value.AutoSize = true;
            this.table_Value.Location = new System.Drawing.Point(12, 90);
            this.table_Value.Name = "table_Value";
            this.table_Value.Size = new System.Drawing.Size(64, 13);
            this.table_Value.TabIndex = 4;
            this.table_Value.Text = "Table Value";
            // 
            // valuetxt_Insert
            // 
            this.valuetxt_Insert.Location = new System.Drawing.Point(90, 83);
            this.valuetxt_Insert.Name = "valuetxt_Insert";
            this.valuetxt_Insert.Size = new System.Drawing.Size(182, 20);
            this.valuetxt_Insert.TabIndex = 5;
            // 
            // instruction_Label
            // 
            this.instruction_Label.AutoSize = true;
            this.instruction_Label.Location = new System.Drawing.Point(53, 9);
            this.instruction_Label.Name = "instruction_Label";
            this.instruction_Label.Size = new System.Drawing.Size(167, 13);
            this.instruction_Label.TabIndex = 6;
            this.instruction_Label.Text = "Please provide all necessary input";
            // 
            // insert_Submit
            // 
            this.insert_Submit.Location = new System.Drawing.Point(15, 109);
            this.insert_Submit.Name = "insert_Submit";
            this.insert_Submit.Size = new System.Drawing.Size(257, 30);
            this.insert_Submit.TabIndex = 7;
            this.insert_Submit.Text = "Submit";
            this.insert_Submit.UseVisualStyleBackColor = true;
            this.insert_Submit.Click += new System.EventHandler(this.insert_Submit_Click);
            // 
            // Insert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.insert_Submit);
            this.Controls.Add(this.instruction_Label);
            this.Controls.Add(this.valuetxt_Insert);
            this.Controls.Add(this.table_Value);
            this.Controls.Add(this.tablecolumn_Label);
            this.Controls.Add(this.columntxt_Insert);
            this.Controls.Add(this.tabletxt_Insert);
            this.Controls.Add(this.inserttable_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Insert_Form";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inserttable_label;
        private System.Windows.Forms.TextBox tabletxt_Insert;
        private System.Windows.Forms.TextBox columntxt_Insert;
        private System.Windows.Forms.Label tablecolumn_Label;
        private System.Windows.Forms.Label table_Value;
        private System.Windows.Forms.TextBox valuetxt_Insert;
        private System.Windows.Forms.Label instruction_Label;
        private System.Windows.Forms.Button insert_Submit;
    }
}