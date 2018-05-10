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
    public partial class TableSelection_Form : Form
    {
        string tableName = "";
        public TableSelection_Form()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            tableName = TableName_TxtBox.Text;
            Close();
        }

        public string GetTableName()
        {
            return tableName;
        }
    }
}
