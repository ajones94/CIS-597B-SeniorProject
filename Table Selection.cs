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

        /// <summary>
        /// Allows user to input table name to be accessed in application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if(TableName_TxtBox.Text == "")
            {
                MessageBox.Show("Input cannot be empty or NULL");
            }
            else
            {
                tableName = TableName_TxtBox.Text;
                Close();
            }
        }

        /// <summary>
        /// Allows for user to access table name
        /// </summary>
        /// <returns>table name</returns>
        public string GetTableName()
        {
            return tableName;
        }
    }
}
