using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccon
{
    class SQLHandler
    {
        public void Update(string updateQuery)
        {
            SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(updateQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        /// <summary>
        /// Create a new connection with Insert Command and then return a DataTable contain returned value.
        /// </summary>
        /// <param name="selectQuery"></param>
        /// <returns></returns>
        public DataTable Select(string selectQuery)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public async Task Insert(string insertString)
        {
            SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
            await sqlConnection.OpenAsync();
            SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
            await cmd.ExecuteNonQueryAsync();
            sqlConnection.Close();
        }
        public void Delete(string deleteString)
        {
            SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(deleteString, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
