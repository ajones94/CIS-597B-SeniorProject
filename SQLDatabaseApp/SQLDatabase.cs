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

        private void connect_button_Click(object sender, EventArgs e)
        {
            SanitizeText(username_txtbox.Text);
            SanitizeText(password_txtbox.Text);
            SanitizeText(database_txtbox.Text);

        }

        public void SanitizeText(string s)
        {
            string pattern = @"['a-zA-Z0-9']+) (\d+)";

            try
            {
                Match result = Regex.Match(s, pattern);
                if (result.Success)
                {
                    return;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("User Input is not in Correct Format, please try again.");
            }
        }
    }
}
