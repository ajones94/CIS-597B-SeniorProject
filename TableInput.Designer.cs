namespace SQLDatabaseApp
{
    partial class TableInputForm
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
            this.table_button = new System.Windows.Forms.Button();
            this.table_txtbox = new System.Windows.Forms.TextBox();
            this.tableInput_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // table_button
            // 
            this.table_button.Location = new System.Drawing.Point(13, 55);
            this.table_button.Name = "table_button";
            this.table_button.Size = new System.Drawing.Size(333, 38);
            this.table_button.TabIndex = 0;
            this.table_button.Text = "Submit";
            this.table_button.UseVisualStyleBackColor = true;
            this.table_button.Click += new System.EventHandler(this.table_button_Click);
            // 
            // table_txtbox
            // 
            this.table_txtbox.Location = new System.Drawing.Point(160, 18);
            this.table_txtbox.Name = "table_txtbox";
            this.table_txtbox.Size = new System.Drawing.Size(186, 20);
            this.table_txtbox.TabIndex = 1;
            // 
            // tableInput_label
            // 
            this.tableInput_label.AutoSize = true;
            this.tableInput_label.Location = new System.Drawing.Point(10, 25);
            this.tableInput_label.Name = "tableInput_label";
            this.tableInput_label.Size = new System.Drawing.Size(144, 13);
            this.tableInput_label.TabIndex = 2;
            this.tableInput_label.Text = "Please enter a table to view: ";
            // 
            // TableInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 113);
            this.Controls.Add(this.tableInput_label);
            this.Controls.Add(this.table_txtbox);
            this.Controls.Add(this.table_button);
            this.Name = "TableInputForm";
            this.Text = "Table ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button table_button;
        private System.Windows.Forms.TextBox table_txtbox;
        private System.Windows.Forms.Label tableInput_label;
    }
}