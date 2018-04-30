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
using System.Text.RegularExpressions;

namespace SQLDatabaseApp
{
    public partial class SQLDatabase : Form
    {
        private string user;
        private string passwd;
        private bool value;
        Admin_Access Admin = new Admin_Access();
        User_Access User = new User_Access();
        SqlConnection sqlConnect;


        public SQLDatabase()
        {
            InitializeComponent();
            password_txtbox.Text = "";
            password_txtbox.PasswordChar = '*';
            password_txtbox.MaxLength = 12;
        }

        public bool SanitizeText(string uname, string psswd)
        {
            string pattern = "^[a-zA-Z0-9_/-@]+$";
            Match userName = Regex.Match(uname, pattern);
            Match passWord = Regex.Match(psswd, pattern);

            if (userName.Success && passWord.Success) { return true; }
            else { return false; }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            user = username_txtbox.Text;
            passwd = password_txtbox.Text;

            value = SanitizeText(user, passwd);

            if (value)
            {
                using (sqlConnect = new SqlConnection())
                {
                    if (user_button.Checked) { User.Show(); User.ObtainConnection(sqlConnect); }
                    else if (admin_button.Checked) { Admin.Show(); Admin.ObtainConnection(sqlConnect); }
                    username_txtbox.Clear();
                    password_txtbox.Clear();
                }
            }
            else
            {
                MessageBox.Show("User input invalid!");
            }
        }
    }
}
