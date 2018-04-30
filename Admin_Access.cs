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
        private TextSanitation textSan;
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

        public void ObtainConnection(SqlConnection sql, TextSanitation ts)
        {
            connection = sql;
            textSan = ts;
            connection.Open();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUser_Form createForm = new CreateUser_Form();
            createForm.ShowDialog();
            createForm.GetData(out username, out password);
            try
            {
                if(textSan.SanitizeText(username) && textSan.SanitizeText(password))
                {
                    command = connection.CreateCommand();
                    command.CommandText = $"GRANT CONNECT TO {username} IDENTIFIED BY {password}";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;
                }
                else { return; }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Incorrect Format");
            }

            command.CommandText = $"GRANT CREATE SESSION TO {username}";
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            CreateTable_Form tableform = new CreateTable_Form();
            tableform.ShowDialog();
            tableform.GetData(out tableName, out columnName, out columnValue);
            try
            {
                if(textSan.SanitizeText(tableName) && textSan.SanitizeText(columnName) && textSan.SanitizeText(columnValue))
                {
                    command = connection.CreateCommand();
                    command.CommandText = $"CREATE TABLE {tableName} ({columnName} {columnValue})";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;
                }
                else { return; }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Incorrect Format");
            }
        }

        private void AssignPriveleges_Click(object sender, EventArgs e)
        {
            AssignPriveleges_Form priveleges = new AssignPriveleges_Form();
            priveleges.ShowDialog();
            priveleges.GetData(out permission, out user, out database);
            try
            {
                if(textSan.SanitizeText(permission) && textSan.SanitizeText(user) && textSan.SanitizeText(database))
                {
                    command = connection.CreateCommand();
                    command.CommandText = $"GRANT {permission} TO {user} ON {database}";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;
                }
                else { return; }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Incorrect Format");
            }
        }
    }
}
