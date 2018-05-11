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

        /// <summary>
        /// Assigns user input to local variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Gets the current input from the user
        /// </summary>
        /// <param name="column1">first row</param>
        /// <param name="column2">second row</param>
        /// <param name="column3">third row</param>
        public void GetCustomerData(out string column1, out string column2, out string column3)
        {

            column1 = Colummn1;
            column2 = Column2;
            column3 = Column3;
        }
    }
}
