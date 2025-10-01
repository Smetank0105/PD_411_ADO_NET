using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MySqlLibrary
{
	public class MyCache
	{
		private SqlConnection _connection;
		private SqlDataAdapter _adapter;
		private DataSet _dataSet;

		public MyCache(string connectionString)
		{
			_connection = new SqlConnection(connectionString);
			_dataSet = new DataSet();
		}
		public DataSet FillDataSet(string cmd, string table_name = "table")
		{
			try
			{
				_adapter = new SqlDataAdapter(cmd, _connection);
				SqlCommandBuilder builder = new SqlCommandBuilder(_adapter);
				_dataSet.Clear();
				_adapter.Fill(_dataSet, table_name);
				return _dataSet;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling DataSet: " + ex.Message);
				throw;
			}
		}
		public void UpdateDatabase(string table_name = "table")
		{
			if (_dataSet == null)
				throw new InvalidOperationException("DataAdapter is not initialized. Call FillDataSet first.");
			try
			{
				_adapter.Update(_dataSet, table_name);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error updating database: " + ex.Message);
				throw;
			}
		}
		public DataTable GetDataTable(string table_name = "table")
		{
			if(_dataSet.Tables.Contains(table_name))
				return _dataSet.Tables[table_name];
			else
				return null;
		}
	}
}
