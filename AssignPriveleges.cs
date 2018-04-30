using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDatabaseApp
{
    public partial class AssignPriveleges_Form : Form
    {
        private string Permission;
        private string User;
        private string Database;
        public AssignPriveleges_Form()
        {
            InitializeComponent();
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            Permission = permission_TxtBox.Text;
            User = user_TxtBox.Text;
            Database = database_TxtBox.Text;
            Close();
        }

        public void GetData(out string permission, out string user, out string database)
        {
            permission = Permission;
            user = User;
            database = Database;
        }
    }
}
