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
        private string user;
        private string passwd;

        Admin_Access Admin = new Admin_Access();
        User_Access User = new User_Access();

        SqlConnection sqlConnect;
        TextSanitation ts = new TextSanitation();


        public SQLDatabase()
        {
            InitializeComponent();

            password_txtbox.Text = "";
            password_txtbox.PasswordChar = '*';
            password_txtbox.MaxLength = 12;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            user = username_txtbox.Text;
            passwd = password_txtbox.Text;

            if (ts.SanitizeText(user) && ts.SanitizeText(passwd))
            {
                using (sqlConnect = new SqlConnection( "Data Source = (localdb) MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
                {
                    if (user_button.Checked) { User.Show(); User.ObtainConnection(sqlConnect, ts); }
                    else if (admin_button.Checked) { Admin.Show(); Admin.ObtainConnection(sqlConnect, ts); }
                    username_txtbox.Clear();
                    password_txtbox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (password_txtbox.Text.Length > 0)
            {
                login_button.Enabled = true;
            }
            else
            {
                login_button.Enabled = false;
            }
        }
    }
}
