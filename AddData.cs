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
    public partial class Insert_Form : Form
    {
        private string table;
        private string column;
        private string dataType;

        public Insert_Form()
        {
            InitializeComponent();
        }

        private void insert_Submit_Click(object sender, EventArgs e)
        {
            table = tabletxt_Insert.Text;
            column = columntxt_Insert.Text;
            dataType = valuetxt_Insert.Text;
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
