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
    public partial class SQLDatabase : Form
    {
        string user = "";
        string password = "";
        string database = "";

        DataAccess_Form User = new DataAccess_Form();
        TextSanitation ts = new TextSanitation();
        DataAccess_Form da = new DataAccess_Form();

        public SQLDatabase()
        {
            InitializeComponent();
            Password_TxtBox.PasswordChar = '*';
            Password_TxtBox.MaxLength = 12;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            user = Username_TxtBox.Text;
            password = Password_TxtBox.Text;
            database = Database_TxtBox.Text;

            if (ts.SanitizeText(user) && ts.SanitizeText(password) && ts.SanitizeText(database))
            {
                try
                {
                    string connectString = $"Persist Security Info=False; Integrated Security = true; Initial Catalog = {database}; server = GAMING-DESKTOP\\SQLSERVER; User ID = {user}; Password = {password};";
                    SqlConnection con = new SqlConnection(connectString);
                    con.Open();

                    da.Show();
                    da.EstablishConnection(con, database);

                    Username_TxtBox.Clear();
                    Password_TxtBox.Clear();
                    Database_TxtBox.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error has occured");
                }
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (Password_TxtBox.Text.Length > 0)
            {
                Login_Button.Enabled = true;
            }
            else
            {
                Login_Button.Enabled = false;
            }
        }
    }
}
