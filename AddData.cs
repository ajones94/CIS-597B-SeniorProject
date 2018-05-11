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
    public partial class AddData_Form : Form
    {
        private string Colummn1;
        private string Column2;
        private string Column3;

        public AddData_Form()
        {
            InitializeComponent();
        }

        private void insert_Submit_Click(object sender, EventArgs e)
        {
            if(Column1_TxtBox.Text == "" || Column2_TxtBox.Text == "" || Column3_TxtBox.Text == "")
            {
                MessageBox.Show("Values must not be Empty or NULL");
            }
            else
            {
                Colummn1 = Column1_TxtBox.Text;
                Column2 = Column2_TxtBox.Text;
                Column3 = Column3_TxtBox.Text;
                Close();
            }
        }

        public void GetCustomerData(out string column1, out string column2, out string column3)
        {

            column1 = Colummn1;
            column2 = Column2;
            column3 = Column3;
        }
    }
}
