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
    public partial class CreateUser_Form : Form
    {
        private string userName;
        private string passWord;
        public CreateUser_Form()
        {
            InitializeComponent();
        }

        public void GetData(out string user, out string password)
        {
            user = userName;
            password = passWord;
        }

        private void submit_Button_Click(object sender, EventArgs e)
        {
            userName = userName_Txt.Text;
            passWord = passWord_Txt.Text;
            Close();
        }
    }
}
