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
    public partial class DataAccess_Form : Form
    {
        private SqlConnection Connection = new SqlConnection();
        private TextSanitation TextSan = new TextSanitation();
        private string Database = "";

        public DataAccess_Form()
        {
            InitializeComponent();
        }

        private void RemoveCustomer_Button_Click(object sender, EventArgs e)
        {
            string customer = "";
            RemoveData_Form removeCustomer = new RemoveData_Form();
            removeCustomer.ShowDialog();
            removeCustomer.GetCustomer(out customer);
            if (TextSan.SanitizeText(customer))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE name = @customer", Connection);
                    cmd.Parameters.AddWithValue("@customer", customer);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ViewCustomers_Button_Click(object sender, EventArgs e)
        {
            string name = " ";
            int id = 0;
            string order = " ";
            CustomerList.Items.Clear();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", Connection);
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        name = sdr["Name"].ToString();
                        id = Convert.ToInt32(sdr["ID"]);
                        order = sdr["OrderStatus"].ToString();
                        string str = name + ": " + id + ": " + order;
                        CustomerList.Items.Add(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateCustomer_button_Click(object sender, EventArgs e)
        {
            string status = "";
            string name = "";
            UpdateData_Form updateCustomer = new UpdateData_Form();
            updateCustomer.ShowDialog();

            updateCustomer.GetStatus(out name, out status);
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET OrderStatus = @status WHERE Name = @name", Connection);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddCustomer_Button_Click(object sender, EventArgs e)
        {
            string name;
            string id;
            string order;
            AddData_Form addCustomer = new AddData_Form();
            addCustomer.ShowDialog();
            addCustomer.GetCustomerData(out name, out id, out order);
            try
            {
                if (TextSan.SanitizeText(name))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO @table (Name, ID, OrderStatus) VALUES (@name, @id, @order)", Connection);
                    cmd.Parameters.AddWithValue("@table", Database);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@order", order);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Incorrect Format");
            }
        }

        public void EstablishConnection(SqlConnection con, string database)
        {
            Connection = con;
            Database = database;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Connection.Close();
            Application.Exit();
        }
    }
}
