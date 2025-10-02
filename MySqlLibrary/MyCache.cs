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
		public void FillDataSet(string cmd, string table_name)
		{
			try
			{
				_adapter = new SqlDataAdapter(cmd, _connection);
				SqlCommandBuilder builder = new SqlCommandBuilder(_adapter);
				_adapter.Fill(_dataSet, table_name);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling DataSet: " + ex.Message);
				throw;
			}
		}
		public void AddPrimaryKey(string table_name, DataColumn[] dataColumns)
		{
			if(!_dataSet.Tables.Contains(table_name))
				throw new ArgumentException($"Table '{table_name}' not found in DataSet.");
			_dataSet.Tables[table_name].PrimaryKey = dataColumns;
		}
		public void AddRelation(string relation_name, string parent_table, string parent_column, string child_table, string child_column)
		{
			if (!_dataSet.Tables.Contains(parent_table))
				throw new ArgumentException($"Table '{parent_table}' not found in DataSet.");
			if (!_dataSet.Tables.Contains(child_table))
				throw new ArgumentException($"Table '{child_table}' not found in DataSet.");
			if (!_dataSet.Tables[parent_table].Columns.Contains(parent_column))
				throw new ArgumentException($"Column '{parent_column}' not found in table '{parent_table}'.");
			if (!_dataSet.Tables[child_table].Columns.Contains(child_column))
				throw new ArgumentException($"Column '{child_column}' not found in table '{child_table}'.");

			//ForeignKeyConstraint fkConstraint = new ForeignKeyConstraint(relation_name, _dataSet.Tables[parent_table].Columns[parent_column], _dataSet.Tables[child_table].Columns[child_column]);
			//fkConstraint.DeleteRule = Rule.Cascade;
			//fkConstraint.UpdateRule = Rule.Cascade;
			//_dataSet.Tables[child_table].Constraints.Add(fkConstraint);

			DataRelation relation = new DataRelation(relation_name, _dataSet.Tables[parent_table].Columns[parent_column], _dataSet.Tables[child_table].Columns[child_column]);
			_dataSet.Relations.Add(relation);
		}
		public void UpdateDatabase(string table_name)
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
		public DataTable GetDataTable(string table_name)
		{
			if(_dataSet.Tables.Contains(table_name))
				return _dataSet.Tables[table_name];
			else
				return null;
		}
		public void DeleteDataSet()
		{
			_dataSet= new DataSet();
		}
	}
}
