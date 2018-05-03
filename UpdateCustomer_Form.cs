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
    public partial class UpdateCustomer_Form : Form
    {
        string name;
        string orderStatus;
        public UpdateCustomer_Form()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            name = CustomerName_TxtBox.Text;
            orderStatus = UpdateCustomer_TxtBox.Text;
            Close();
        }

        public void GetStatus(out string Name, out string OrderStatus)
        {
            Name = name;
            OrderStatus = orderStatus;
        }
    }
}
