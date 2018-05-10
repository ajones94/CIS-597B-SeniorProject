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
        private string table = "";
        Table tableColumns;
        private string columnNames = "";

        public DataAccess_Form()
        {
            InitializeComponent();
        }

        public void EstablishConnection(SqlConnection con)
        {
            Connection = con;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Connection.Close();
            Application.Exit();
        }

        private void AddData_Button_Click(object sender, EventArgs e)
        {
            if (table != null || table != "")
            {
                string name;
                string id;
                string order;
                AddData_Form addCustomer = new AddData_Form();
                addCustomer.ShowDialog();
                addCustomer.GetCustomerData(out name, out id, out order);

                if (TextSan.SanitizeText(name))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO @table (Name, ID, OrderStatus) VALUES (@name, @id, @order)", Connection);
                        cmd.Parameters.AddWithValue("@table", table);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@order", order);
                        cmd.ExecuteNonQuery();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Incorrect Format");
                    }
                }
            }
            else
            {
                MessageBox.Show("A Table must be selected before Adding, Removing, or Viewing Data");
                return;
            }
        }

        private void RemoveData_Button_Click(object sender, EventArgs e)
        {
            string column = "";
            string value = "";

            if(table != null || table != "")
            {
                RemoveData_Form removeData = new RemoveData_Form();
                removeData.ShowDialog();
                removeData.GetData(out column, out value);

                if (TextSan.SanitizeText(column) && TextSan.SanitizeText(value))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM @table WHERE @column = @Value", Connection);
                        cmd.Parameters.AddWithValue("@table", table);
                        cmd.Parameters.AddWithValue("@column", column);
                        cmd.Parameters.AddWithValue("@value", value);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("A Table must be selected before Adding, Removing, or Viewing Data");
                return;
            }
        }

        private void UpdateData_button_Click(object sender, EventArgs e)
        {
            string columnUpdate;
            string updateValue;
            string columnName;
            string rowName;
            if(table != null || table != "")
            {
                UpdateData_Form updateData = new UpdateData_Form();
                updateData.ShowDialog();
                updateData.GetStatus(out columnUpdate, out updateValue, out columnName, out rowName);

                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE @table SET @columnUpdate = @update WHERE @columnName = @rowData", Connection);
                    cmd.Parameters.AddWithValue("@table", table);
                    cmd.Parameters.AddWithValue("@columnUpdate", columnUpdate);
                    cmd.Parameters.AddWithValue("@update", updateValue);
                    cmd.Parameters.AddWithValue("@columnName", columnName);
                    cmd.Parameters.AddWithValue("@rowData", rowName);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("A Table must be selected before Adding, Removing, or Viewing Data");
                return;
            }
        }

        private void SelectTable_Button_Click(object sender, EventArgs e)
        {
            TableSelection_Form tableSelect = new TableSelection_Form();
            tableSelect.ShowDialog();
            table = tableSelect.GetTableName();
            tableColumns = new Table(Connection, table);
            columnNames = tableColumns.GetColumnNames();
        }

        private void ViewData_Button_Click(object sender, EventArgs e)
        {
            if(table != null || table != "")
            {
                CustomerList.Items.Clear();
                DataTable table = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM {table}", Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("A Table must be selected before Adding, Removing, or Viewing Data");
                return;
            }
        }
    }
}
