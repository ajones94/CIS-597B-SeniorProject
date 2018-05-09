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
        string ColumnName;
        string ColumnValue;
        public UpdateData_Form()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            ColumnName = UpdateColumn_TxtBox.Text;
            ColumnValue = UpdateValue_TxtBox.Text;

            Close();
        }

        public void GetStatus(out string column, out string value)
        {
            column = ColumnName;
            value = ColumnValue;
        }
    }
}
