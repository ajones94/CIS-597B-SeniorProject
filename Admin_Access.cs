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
        private SqlCommand command;

        private string username;
        private string password;

        private string tableName;
        private string columnName;
        private string columnValue;

        private string permission;
        private string user;
        private string database;

        public Admin_Access()
        {
            InitializeComponent();
        }

        public void ObtainConnection(SqlConnection sql)
        {
            connection = sql;
        }
        private void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUser_Form createForm = new CreateUser_Form();
            createForm.ShowDialog();
            createForm.GetData(out username, out password);
            try
            {
                command = connection.CreateCommand();
                command.CommandText = $"GRANT CONNECT TO {username} IDENTIFIED BY {password}";
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 30;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error Occured!");
            }
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            CreateTable_Form tableform = new CreateTable_Form();
            tableform.ShowDialog();
            tableform.GetData(out tableName, out columnName, out columnValue);
            try
            {
                command = connection.CreateCommand();
                command.CommandText = $"CREATE TABLE {tableName} ({columnName} {columnValue})";
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 30;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error Occured!");
            }
        }

        private void AssignPriveleges_Click(object sender, EventArgs e)
        {
            AssignPriveleges_Form priveleges = new AssignPriveleges_Form();
            priveleges.ShowDialog();
            priveleges.GetValues(out permission, out user, out database);
            try
            {
                command = connection.CreateCommand();
                command.CommandText = $"GRANT {permission} TO {user} ON {database}";
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 30;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("An Error Has Occured");
            }
        }
    }
}
