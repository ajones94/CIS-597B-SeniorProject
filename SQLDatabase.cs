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
            SqlConnection Connection;
            string userName = username_txtbox.Text;
            string passWord = password_txtbox.Text;
            string dataBase = database_txtbox.Text;

            bool results = SanitizeText(userName, passWord, dataBase);
            if(results == true) {
                Connection = new SqlConnection(
                    "user id = " + userName + "; password = " + passWord + "; server=serverurl;" + 
                    "Trusted_Connection = yes;" + "database = " + dataBase + "; connection timeout = 15"
                    );
            }
            else { MessageBox.Show("Username, Password, or Database in incorrect format"); }

            try
            {
                Connection.Open();
            }
        }

        public bool SanitizeText(string uname, string psswd, string db)
        {
            string pattern = "^[a-zA-Z0-9_/-@]+$";
            Match userName = Regex.Match(uname, pattern);
            Match passWord = Regex.Match(psswd, pattern);
            Match dataBase = Regex.Match(db, pattern);

            if (userName.Success && passWord.Success && dataBase.Success) { return true; }
            else { return false; }
        }
    }
}
