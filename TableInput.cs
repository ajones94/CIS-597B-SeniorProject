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
    public partial class TableInputForm : Form
    {
        private string table;
        public TableInputForm()
        {
            InitializeComponent();
        }

        private void table_button_Click(object sender, EventArgs e)
        {
            table = table_txtbox.Text;
            Close();
        }
        public string GetTable()
        {
            return table;
        }
    }
}
