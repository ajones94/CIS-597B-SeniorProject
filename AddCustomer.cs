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
    public partial class AddCustomer_Form : Form
    {
        private string customerName;
        private string customerID;
        private string customerOrder;

        public AddCustomer_Form()
        {
            InitializeComponent();
        }

        private void insert_Submit_Click(object sender, EventArgs e)
        {
            customerName = customerName_TxtBox.Text;
            customerID = customerID_TxtBox.Text;
            customerOrder = CustomerOrder_TxtBox.Text;
            Close();
        }

        public void GetCustomerData(out string name, out string id, out string order)
        {
            name = customerName;
            id = customerID;
            order = customerOrder;
        }
    }
}
