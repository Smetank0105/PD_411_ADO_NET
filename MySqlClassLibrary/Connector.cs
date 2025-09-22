using System.Data.SqlClient;
namespace MySqlClassLibrary
{
	public class Connector
	{
		private readonly string _connectionString;
		protected SqlConnection _connection;
		public Connector(string connectionString)
		{
			_connectionString = connectionString;
			_connection = new SqlConnection();
			_connection.ConnectionString = _connectionString;
		}
		public object Scalar(string cmd)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand(cmd, _connection);
			object result = command.ExecuteScalar();
			_connection.Close();
			return result;
		}
		public void Insert(string table, string fields, string values)
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
			string cmd = $"IF NOT EXISTS(SELECT {primary_key} FROM {table} WHERE {condition}) BEGIN INSERT {table}({fields}) VALUES ({condition}); END";
			SqlCommand command = new SqlCommand(cmd, _connection);
			_connection.Open();
			command.ExecuteNonQuery();
			_connection.Close();
		}
		public void Select(string fields, string tables, string condition = "")
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
	}
}
