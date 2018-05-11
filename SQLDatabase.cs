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

        TextSanitation ts = new TextSanitation();

        public SQLDatabase()
        {
            InitializeComponent();
            Password_TxtBox.PasswordChar = '*';
            Password_TxtBox.MaxLength = 12;
        }

        /// <summary>
        /// Takes the current input from user to construct an SQLConnection using a specified connnection string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Button_Click(object sender, EventArgs e)
        {
            user = Username_TxtBox.Text;
            password = Password_TxtBox.Text;
            database = Database_TxtBox.Text;
            DataAccess_Form da = new DataAccess_Form();

            if (ts.SanitizeText(user) && ts.SanitizeText(password) && ts.SanitizeText(database))
            {
                try
                {
                    string connectString = $"Persist Security Info=False; Integrated Security = true; Initial Catalog = {database}; server = GAMING-DESKTOP\\SQLSERVER; User ID = {user}; Password = {password};";
                    SqlConnection con = new SqlConnection(connectString);
                    con.Open();

                    da.Show();
                    da.EstablishConnection(con);

                    Username_TxtBox.Clear();
                    Password_TxtBox.Clear();
                    Database_TxtBox.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error has occured" + ex.ToString());
                }
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Enables login button if password field is greater than zero characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
