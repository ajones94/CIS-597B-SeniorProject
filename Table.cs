using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            StringBuilder sb = new StringBuilder();
            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName}", connection))
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    for(int i = 0; i < rd.FieldCount; i++)
                    {
                        sb.Append(rd.GetName(i) + ", ");
                    }
                }
            }
            return sb.ToString();
        }
    }
}
