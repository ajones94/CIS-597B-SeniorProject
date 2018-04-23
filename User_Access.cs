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
    public partial class User_Access : Form
    {
        private SqlConnection Connection;
        private SqlCommand command;
        public User_Access()
        {
            InitializeComponent();
        }

        public void ObtainConnection(SqlConnection connection)
        {
            Connection = connection;
        }

        private void addData_button_Click(object sender, EventArgs e)
        {

        }

        private void RemoveData_Click(object sender, EventArgs e)
        {

        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            TableInputForm tableInput = new TableInputForm();
            tableInput.Show();
            string table = tableInput.GetTable();
            try
            {
                command = Connection.CreateCommand();
                command.CommandText = $"SELECT * from {table}";
                using (SqlDataReader sdr = command.ExecuteReader())
                {
                    if (sdr != null)
                    {
                        sqlData_list.Items.Add(sdr);
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid Table");
            }
        }
    }
}
