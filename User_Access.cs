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
        private TextSanitation textSan;
        private SqlCommand command;

        string createTable;
        string createColumn;
        string createDatatype;

        string removeTable;
        string removeColumn;
        string removeDatatype;

        public User_Access()
        {
            InitializeComponent();
        }

        public void ObtainConnection(SqlConnection connection, TextSanitation ts)
        {
            Connection = connection;
            textSan = ts;
            Connection.Open();
        }

        private void addData_button_Click(object sender, EventArgs e)
        {
            Insert_Form insertForm = new Insert_Form();
            insertForm.ShowDialog();
            insertForm.GetData(out createTable, out createColumn, out createDatatype);

            try
            {
                if(textSan.SanitizeText(createTable) && textSan.SanitizeText(createColumn) && textSan.SanitizeText(createDatatype))
                {
                    command = Connection.CreateCommand();
                    command.CommandText = $"INSERT INTO {createTable} ({createColumn}) VALUES ({createDatatype})";
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

        private void RemoveData_Click(object sender, EventArgs e)
        {
            delete_Form deleteForm = new delete_Form();
            deleteForm.ShowDialog();
            deleteForm.GetData(out removeTable, out removeColumn, out removeDatatype);
            try
            {
                if(textSan.SanitizeText(removeTable) && textSan.SanitizeText(removeColumn) && textSan.SanitizeText(removeDatatype))
                {
                    command = Connection.CreateCommand();
                    command.CommandText = $"DELETE FROM {removeTable} WHERE {removeColumn} = {removeDatatype}";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;
                }
                else { return; }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Incorrect Format");
            }
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            TableInputForm tableInput = new TableInputForm();
            tableInput.ShowDialog();
            string table = tableInput.GetTable();
            List<string> data = new List<string>();
            try
            {
                if (textSan.SanitizeText(table))
                {
                    command = Connection.CreateCommand();
                    command.CommandText = $"SELECT * from {table}";
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 30;

                    using(SqlDataReader sdr = command.ExecuteReader())
                    {
                        int i = 0;
                        data.Add(sdr[i].ToString());
                        i++;
                    }
                    sqlData_GridView.DataSource = data;
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
