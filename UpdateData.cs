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

        public void GetStatus(out string ColumnUpdated, out string RowUpdated, out string ColumnToUpdate, out string RowToUpdate)
        {
            ColumnUpdated = columnToBeUpdated;
            RowUpdated = RowToBeUpdated;
            ColumnToUpdate = ColumnThatAppliesUpdate;
            RowToUpdate = RowThatAppliesUpdate;
        }
    }
}
