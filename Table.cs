using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLDatabaseApp
{
    public class Table
    {
        SqlConnection connection;
        string tableName;
        public Table(SqlConnection conn, string table)
        {
            connection = conn;
            tableName = table;
        }

        public string GetColumnNames()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName}", connection))
            {
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    dt = rd.GetSchemaTable();
                    foreach(DataRow field in dt.Rows)
                    {
                        sb.Append(field[0].ToString() + ", ");
                    }
                }
            }
            
            return sb.ToString();
        }
    }
}
