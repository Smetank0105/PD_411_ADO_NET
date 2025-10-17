using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtools
{
	public class Connector
	{
		string connectionString = "";
		SqlConnection connection = null;
		public Connector()
		{
			connectionString = ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString;
			connection = new SqlConnection(connectionString);
		}
		public object Scalar(string cmd)
		{
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			object result = command.ExecuteScalar();
			connection.Close();
			return result;
		}
		public string GetPrimaryKey(string table)
		{
			return Scalar
				(
				$@"SELECT COLUMN_NAME 
				FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
				WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA+'.'+QUOTENAME(CONSTRAINT_NAME)),'IsPrimaryKey')=1 
				AND TABLE_NAME = '{table}'"
				) as string;
		}
		public DataTable Select(string fields, string tables, string condition = "")
		{
			DataTable table = new DataTable();
			string cmd = $"SELECT {fields} FROM {tables}";
			if (!string.IsNullOrWhiteSpace(condition)) cmd += $" WHERE {condition}";
			cmd += ";";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			return table;
		}
		public void Insert(string table, string fields, string values)
		{
			string cmd = $"INSERT {table} ({fields}) VALUES ({values})";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public void Insert(string table, SqlCommand command)
		{
			string values = "";
			string fields = "";
			foreach (SqlParameter param in command.Parameters)
			{
				values += param.ParameterName + ",";
				fields += param.ParameterName.Remove(0, 1) + ",";
			}
			values = values.Substring(0, values.Length - 1);
			fields = fields.Substring(0, fields.Length - 1);
			string cmd = $"INSERT INTO {table} ({fields}) VALUES ({values})";
			command.CommandText = cmd;
			command.Connection = connection;
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public void Update(string table, string fields, string conditions)
		{
			string cmd = $"UPDATE {table} SET {fields} WHERE {conditions}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public void Update(string table, string conditions, SqlCommand command)
		{
			string values = "";
			foreach (SqlParameter param in command.Parameters)
				values += param.ParameterName.Remove(0, 1) + "=" + param.ParameterName + ",";
			values = values.Substring(0, values.Length - 1);
			string cmd = $"UPDATE {table} SET {values} WHERE {conditions}";
			command.CommandText = cmd;
			command.Connection = connection;
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public void UploadPhoto(byte[] image, int id, string field, string table)
		{
			string cmd = $"UPDATE {table} SET {field}=@image WHERE {GetPrimaryKey(table)}={id}";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.Add("@image", SqlDbType.VarBinary).Value = image;
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public Image LoadPhoto(int id, string table, string field)
		{
			byte[] bytes = null;
			string cmd = $"SELECT {field} FROM {table} WHERE {GetPrimaryKey(table)} = {id}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				if (reader["Photo"] != DBNull.Value)
				{
					bytes = (byte[])reader["Photo"];
				}
			}
			connection.Close();
			MemoryStream ms = new MemoryStream(bytes);
			return Image.FromStream(ms);
		}
	}
}
