using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLDatabaseApp
{
    public partial class Admin_Access : Form
    {
        private SqlConnection connection;
        public Admin_Access()
        {
            InitializeComponent();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {

        }

        private void CreateTable_Click(object sender, EventArgs e)
        {

        }

        private void AssignPriveleges_Click(object sender, EventArgs e)
        {

        }

        public void ObtainConnection(SqlConnection sql)
        {
            connection = sql;
        }
    }
}
