using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Diccon
{
    class SQLHandler
    {
        public async Task UpdateAsync(string updateQuery)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DicconProp.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(updateQuery, sqlConnection))
            {
                await sqlConnection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
        /// <summary>
        /// Create a new connection with Insert Command and then return a DataTable contain returned value.
        /// </summary>
        /// <param name="selectQuery"></param>
        /// <returns></returns>
        public async Task<DataTable> SelectAsync(string selectQuery)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(DicconProp.ConnectionString))
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection))
            {
                await sqlConnection.OpenAsync();
                sqlDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public async Task InsertAsync(string insertString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DicconProp.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(insertString, sqlConnection))
            {
                await sqlConnection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
        public async Task DeleteAsync(string deleteString)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DicconProp.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(deleteString, sqlConnection))
            {
                await sqlConnection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
