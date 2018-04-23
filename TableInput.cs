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
        public TableInputForm()
        {
            InitializeComponent();
        }

        private void table_button_Click(object sender, EventArgs e)
        {
            GetTable();
        }
        public string GetTable()
        {
            return table_txtbox.Text;
        }
    }
}
