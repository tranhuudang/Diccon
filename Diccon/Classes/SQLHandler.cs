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
		
		connectivity connectivity = new connectivity();

		
		public void Update(string updateQuery)
		{

			if (connectivity.isOnline())
			{

				SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
				sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(updateQuery, sqlConnection);
				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			else
			{
				MessageBox.Show(dicconProp.internetError);
			}
		}
		/// <summary>
		/// Create a new connection with Insert Command and then return a DataTable contain returned value.
		/// </summary>
		/// <param name="selectQuery"></param>
		/// <returns></returns>
		public DataTable Select(string selectQuery)
		{
			DataTable dataTable = new DataTable();
			if (connectivity.isOnline())
			{
				SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
				sqlConnection.Open();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
				sqlDataAdapter.Fill(dataTable);
				return dataTable;
			}
			else
			{
				MessageBox.Show(dicconProp.internetError);
				return dataTable;
			}
		}
		public void Insert(string insertString)
		{
			if (connectivity.isOnline())
			{
				SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			else
			{
				MessageBox.Show(dicconProp.internetError);
			}
		}
	}
}
