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
        string[] columns;

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
            Close();
        }

        private void AddData_Button_Click(object sender, EventArgs e)
        {
            if (table != "")
            {
                string value1;
                string value2;
                string value3;
                AddData_Form addCustomer = new AddData_Form();
                addCustomer.ShowDialog();
                addCustomer.GetCustomerData(out value1, out value2, out value3);
                if (TextSan.SanitizeText(value1) && TextSan.SanitizeText(value2) && TextSan.SanitizeText(value3))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand($"INSERT INTO {table} ({columns[0]}, {columns[1]}, {columns[2]}) VALUES (@value1, @value2, @value3)", Connection);
                        cmd.Parameters.AddWithValue("@value1",value1);
                        cmd.Parameters.AddWithValue("@value2", value2);
                        cmd.Parameters.AddWithValue("@value3", value3);
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
                MessageBox.Show("A Table must be selected before Adding, Removing, Updating, or Viewing Data");
                return;
            }
        }

        private void RemoveData_Button_Click(object sender, EventArgs e)
        {
            string column = "";
            string value = "";

            if(table != "")
            {
                RemoveData_Form removeData = new RemoveData_Form();
                removeData.ShowDialog();
                removeData.GetData(out column, out value);
                if (TextSan.SanitizeText(column) && TextSan.SanitizeText(value))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand($"DELETE FROM {table} WHERE {column} = @value", Connection);
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
                MessageBox.Show("A Table must be selected before Adding, Removing, Updating, or Viewing Data");
                return;
            }
        }

        private void UpdateData_button_Click(object sender, EventArgs e)
        {
            string columnUpdate;
            string updateValue;
            string columnName;
            string rowName;
            if(table != "")
            {
                UpdateData_Form updateData = new UpdateData_Form();
                updateData.ShowDialog();
                updateData.GetStatus(out columnUpdate, out updateValue, out columnName, out rowName);

                try
                {
                    SqlCommand cmd = new SqlCommand($"UPDATE {table} SET {columnUpdate} = @update WHERE {columnName} = @rowData", Connection);
                    cmd.Parameters.AddWithValue("@update", updateValue);
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
                MessageBox.Show("A Table must be selected before Adding, Removing, Updating, or Viewing Data");
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
            columns = columnNames.Split(',');
        }

        private void ViewData_Button_Click(object sender, EventArgs e)
        {
            DataView.Items.Clear();
            if(table != "")
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM {table} ", Connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListViewItem row = new ListViewItem(dt.Rows[i][0].ToString());
                        for(int j = 1; j < dt.Columns.Count; j++)
                        {
                            row.SubItems.Add(dt.Rows[i][j].ToString());
                        }
                        DataView.Items.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("A Table must be selected before Adding, Removing, Updating, or Viewing Data");
                return;
            }
        }
    }
}
