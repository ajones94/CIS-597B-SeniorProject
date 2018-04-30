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
    public partial class CreateTable_Form : Form
    {
        private string Table;
        private string Column;
        private string Datatype;
        public CreateTable_Form()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Table = table_txtBox.Text;
            Column = column_txtBox.Text;
            Datatype = datatype_txtBox.Text;
            Close();
        }

        public void GetData(out string table, out string column, out string datatype)
        {
            table = Table;
            column = Column;
            datatype = Datatype;
        }
    }
}
