using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatabaseApp
{
    public partial class UpdateData_Form : Form
    {
        string columnToBeUpdated = "";
        string RowToBeUpdated = "";
        string ColumnThatAppliesUpdate = "";
        string RowThatAppliesUpdate = "";

        public UpdateData_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows for users to implement column and row tdata o be updated in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if(ColumnToBeUpdated_TxtBox.Text == "" || RowToBeUpdated_TxtBox.Text == "" || ColumnThatAppliesUpdate_TxtBox.Text == "" || RowThatAppliesUpdate_TxtBox.Text == "")
            {
                MessageBox.Show("Input cannot be empty or NULL");
            }
            else
            {
                columnToBeUpdated = ColumnToBeUpdated_TxtBox.Text;
                RowToBeUpdated = RowToBeUpdated_TxtBox.Text;
                ColumnThatAppliesUpdate = ColumnThatAppliesUpdate_TxtBox.Text;
                RowThatAppliesUpdate = RowThatAppliesUpdate_TxtBox.Text;
                Close();
            }
        }

        /// <summary>
        /// Gets the current input from the user
        /// </summary>
        /// <param name="ColumnUpdated">Column of value to be implemented</param>
        /// <param name="RowUpdated">Row that has its value updated</param>
        /// <param name="ColumnToUpdate">Column where this update applies</param>
        /// <param name="RowToUpdate">Row where this update applies</param>
        public void GetStatus(out string ColumnUpdated, out string RowUpdated, out string ColumnToUpdate, out string RowToUpdate)
        {
            ColumnUpdated = columnToBeUpdated;
            RowUpdated = RowToBeUpdated;
            ColumnToUpdate = ColumnThatAppliesUpdate;
            RowToUpdate = RowThatAppliesUpdate;
        }
    }
}
