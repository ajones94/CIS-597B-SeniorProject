namespace SQLDatabaseApp
{
    partial class DataAccess_Form
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
            this.RemoveData_Button = new System.Windows.Forms.Button();
            this.ViewData_Button = new System.Windows.Forms.Button();
            this.UpdateData_button = new System.Windows.Forms.Button();
            this.AddData_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SelectTable_Button = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.ListView();
            this.Column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RemoveData_Button
            // 
            this.RemoveData_Button.Location = new System.Drawing.Point(12, 50);
            this.RemoveData_Button.Name = "RemoveData_Button";
            this.RemoveData_Button.Size = new System.Drawing.Size(89, 41);
            this.RemoveData_Button.TabIndex = 1;
            this.RemoveData_Button.Text = "Remove Data";
            this.RemoveData_Button.UseVisualStyleBackColor = true;
            this.RemoveData_Button.Click += new System.EventHandler(this.RemoveData_Button_Click);
            // 
            // ViewData_Button
            // 
            this.ViewData_Button.Location = new System.Drawing.Point(12, 97);
            this.ViewData_Button.Name = "ViewData_Button";
            this.ViewData_Button.Size = new System.Drawing.Size(89, 40);
            this.ViewData_Button.TabIndex = 3;
            this.ViewData_Button.Text = "View Data";
            this.ViewData_Button.UseVisualStyleBackColor = true;
            this.ViewData_Button.Click += new System.EventHandler(this.ViewData_Button_Click);
            // 
            // UpdateData_button
            // 
            this.UpdateData_button.Location = new System.Drawing.Point(12, 143);
            this.UpdateData_button.Name = "UpdateData_button";
            this.UpdateData_button.Size = new System.Drawing.Size(89, 42);
            this.UpdateData_button.TabIndex = 5;
            this.UpdateData_button.Text = "Update Data";
            this.UpdateData_button.UseVisualStyleBackColor = true;
            this.UpdateData_button.Click += new System.EventHandler(this.UpdateData_button_Click);
            // 
            // AddData_Button
            // 
            this.AddData_Button.Location = new System.Drawing.Point(12, 12);
            this.AddData_Button.Name = "AddData_Button";
            this.AddData_Button.Size = new System.Drawing.Size(89, 32);
            this.AddData_Button.TabIndex = 6;
            this.AddData_Button.Text = "Add Data";
            this.AddData_Button.UseVisualStyleBackColor = true;
            this.AddData_Button.Click += new System.EventHandler(this.AddData_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(12, 399);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(89, 31);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // SelectTable_Button
            // 
            this.SelectTable_Button.Location = new System.Drawing.Point(12, 190);
            this.SelectTable_Button.Margin = new System.Windows.Forms.Padding(2);
            this.SelectTable_Button.Name = "SelectTable_Button";
            this.SelectTable_Button.Size = new System.Drawing.Size(89, 34);
            this.SelectTable_Button.TabIndex = 9;
            this.SelectTable_Button.Text = "Select Table";
            this.SelectTable_Button.UseVisualStyleBackColor = true;
            this.SelectTable_Button.Click += new System.EventHandler(this.SelectTable_Button_Click);
            // 
            // DataView
            // 
            this.DataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataView.GridLines = true;
            this.DataView.Location = new System.Drawing.Point(106, 14);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(368, 418);
            this.DataView.TabIndex = 10;
            this.DataView.UseCompatibleStateImageBehavior = false;
            this.DataView.View = System.Windows.Forms.View.Details;
            // 
            // Column1
            // 
            this.Column1.Text = "Column1";
            // 
            // Column2
            // 
            this.Column2.Text = "Column2";
            // 
            // Column3
            // 
            this.Column3.Text = "Column3";
            // 
            // DataAccess_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 444);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.SelectTable_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.AddData_Button);
            this.Controls.Add(this.UpdateData_button);
            this.Controls.Add(this.ViewData_Button);
            this.Controls.Add(this.RemoveData_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DataAccess_Form";
            this.Text = "Data Access";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveData_Button;
        private System.Windows.Forms.Button AddData_Button;
        private System.Windows.Forms.Button ViewData_Button;
        private System.Windows.Forms.Button UpdateData_button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button SelectTable_Button;
        private System.Windows.Forms.ListView DataView;
        private System.Windows.Forms.ColumnHeader Column1;
        private System.Windows.Forms.ColumnHeader Column2;
        private System.Windows.Forms.ColumnHeader Column3;
    }
}