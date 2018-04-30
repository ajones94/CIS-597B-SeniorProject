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
    public partial class delete_Form : Form
    {
        private string table;
        private string column;
        private string dataType;

        public delete_Form()
        {
            InitializeComponent();
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            table = table_txtBox.Text;
            column = column_txtBox.Text;
            dataType = data_txtBox.Text;
            Close();
        }

        public void GetData(out string Table, out string Column, out string Datatype)
        {
            Table = table;
            Column = column;
            Datatype = dataType;
        }
    }
}
