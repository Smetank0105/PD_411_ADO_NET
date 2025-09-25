using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MySqlLibrary
{
	public class MyConnector
	{
		protected SqlConnection _connection;
		protected string _table_name { get; set; }
		protected DataTable _columns;
		public MyConnector(string connectionString, string table_name)
		{
			_connection = new SqlConnection();
			_connection.ConnectionString = connectionString;
			_table_name = table_name;
			SetColumnsName();
		}
		private void SetColumnsName()
		{
			SqlCommand command = new SqlCommand();
			_connection.Open();
			DataTable schema = _connection.GetSchema("Columns", new string[] { null, null, _table_name, null });
			DataView dv = schema.DefaultView;
			dv.Sort = "ORDINAL_POSITION ASC";
			_columns = dv.ToTable();
			_connection.Close();
		}
		public object Scalar(string cmd)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand(cmd, _connection);
			object result = command.ExecuteScalar();
			_connection.Close();
			return result;
		}
		public int Insert(string table, string fields, string values)
		{
			string primary_key = Scalar
				(
				$@"SELECT COLUMN_NAME 
				FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
				WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA+'.'+QUOTENAME(CONSTRAINT_NAME)),'IsPrimaryKey')=1 
				AND TABLE_NAME = '{table}'"
				) as string;
			string[] fields_for_check = fields.Split(',');
			string[] values_for_check = values.Split(',');
			string condition = "";
			for (int i = 0; i < fields_for_check.Length; i++)
				condition += $" {fields_for_check[i]} = {values_for_check[i]} AND";
			condition = condition.Remove(condition.LastIndexOf(' '), 4);
			string cmd = $"IF NOT EXISTS(SELECT {primary_key} FROM {table} WHERE {condition}) BEGIN INSERT {table}({fields}) VALUES ({values}); END";
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			int result = command.ExecuteNonQuery();
			_connection.Close();
			return result;
		}
		public int Insert(string values)
		{
			string[] values_for_check = values.Split(',');
			string[] fields_name = new string[values_for_check.Length];
			string condition = "";
			for (int j = 0, i = values_for_check.Length == _columns.Rows.Count ? 0 : 1; i < _columns.Rows.Count; j++, i++)
			{
				fields_name[i] = $"[{_columns.Rows[i]["COLUMN_NAME"].ToString()}]";
				if(i > 0)
					condition += $" {fields_name[i]} = {values_for_check[j]} AND";
			}
			condition = condition.Remove(condition.LastIndexOf(' '), 4);
			string fields = string.Join(",", fields_name);
			string cmd = $"IF NOT EXISTS(SELECT {_columns.Rows[0]["COLUMN_NAME"].ToString()} FROM {_table_name} WHERE {condition}) BEGIN INSERT {_table_name} ({fields}) VALUES ({values}); END";
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			int result =  command.ExecuteNonQuery();
			_connection.Close() ;
			return result;
		}
		public int Update(string values, string condition)
		{
			string[] values_for_check = values.Split(',');
			string[] fields_name = new string[values_for_check.Length];
			string set_values = "";
			for (int i = 0; i < values_for_check.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(values_for_check[i])) continue;
				set_values += $" [{_columns.Rows[i + 1]["COLUMN_NAME"].ToString()}] = {values_for_check[i]},";
			}
			set_values = set_values.Remove(set_values.Length - 1);
			string cmd = $"UPDATE {_table_name} SET {set_values} WHERE {condition};";
			//Console.WriteLine(cmd);
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			int result = command.ExecuteNonQuery();
			_connection.Close() ;
			return result;
		}
		public int Delete(string condition)
		{
			string cmd = $"DELETE FROM {_table_name} WHERE {condition};";
			SqlCommand command= new SqlCommand(cmd, _connection);
			_connection.Open();
			int result = command.ExecuteNonQuery();
			_connection.Close() ;
			return result;
		}
		public void SelectToConsole(string fields, string tables, string condition = "")
		{
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i) + "\t");
			}
			Console.WriteLine();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader[i] + "\t\t");
				Console.WriteLine();
			}
			reader.Close();
			_connection.Close();
		}
		public DataTable Select(string cmd)
		{
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			DataTable table = new DataTable();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));
			DataRow row = table.NewRow();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; i++)
					row[i] = reader[i];
				table.Rows.Add(row);
			}
			reader.Close();
			_connection.Close();
			return table;
		}
		public static DataTable Select(string connectionString, string cmd)
		{
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand command = new SqlCommand(cmd, conn);
			conn.Open();
			DataTable table = new DataTable();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
					row[i] = reader[i];
				table.Rows.Add(row);
			}
			reader.Close();
			conn.Close();
			return table;
		}
	}
}
