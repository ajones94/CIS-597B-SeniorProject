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
        string updateColumn = "";
        string updateValue = "";
        string columnToUpdate = "";
        string rowToUpdate = "";
        public UpdateData_Form()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            updateColumn = UpdatedColumn_TxtBox.Text;
            updateValue = UpdatedValue_TxtBox.Text;
            columnToUpdate = WhereToApply_TxtBox.Text;
            rowToUpdate = RowValueToUpdate_TxtBox.Text;
            Close();
        }

        public void GetStatus(out string columnUpdate, out string valueUpdate, out string selectCol, out string RowValue)
        {
            columnUpdate = updateColumn;
            valueUpdate = updateValue;
            selectCol = columnToUpdate;
            RowValue = rowToUpdate; 
        }
    }
}
