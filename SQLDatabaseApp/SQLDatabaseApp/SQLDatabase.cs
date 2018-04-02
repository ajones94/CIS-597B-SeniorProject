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
        public SQLDatabase()
        {
            InitializeComponent();
        }

        private void user_login_button_Click(object sender, EventArgs e)
        {
            SanitizeText(username_txtbox.Text);
            SanitizeText(password_txtbox.Text);
            SanitizeText(database_txtbox.Text);
            MessageBox.Show("You've successfully logged in!");
        }

        public void SanitizeText(string s)
        {
            string pattern = "^[a-zA-Z0-9_-@]+$";
            Match match = Regex.Match(s, pattern);

            if (match.Success) { return; }
            else { MessageBox.Show("String is not in the correct format!"); }
        }
    }
}
