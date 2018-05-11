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
    public partial class RemoveData_Form : Form
    {
        private string Column;
        private string Value;

        public RemoveData_Form()
        {
            InitializeComponent();
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            if(ColumnName_TxtBox.Text == "" || ColumnValue_Txtbox.Text == "")
            {
                MessageBox.Show("Input must not be Empty or NULL");
            }
            else
            {
                Column = ColumnName_TxtBox.Text;
                Value = ColumnValue_Txtbox.Text;
                Close();
            }
        }

        public void GetData(out string column, out string value)
        {
            column = Column;
            value = Value;
        }
    }
}
