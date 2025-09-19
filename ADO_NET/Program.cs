//#define SCALAR_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;

namespace ADO_NET
{
	class Program
	{
		static string connectionString = "";
		static SqlConnection connection;
		static void Main(string[] args)
		{
			//0) Достаем строку подключения из AppConfig
			connectionString = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
			//1) Создаем подключчение к Базе Данны на Сервере
			Console.WriteLine(connectionString);
			connection = new SqlConnection();
			connection.ConnectionString = connectionString;

#if SCALAR_CHECK
			Select("*", "Directors");
			Select("movie_name,first_name+last_name AS director", "Movies, Directors", "director=director_id");

			connection.Open();
			string cmd = "SELECT COUNT(*) FROM Directors";
			SqlCommand command = new SqlCommand(cmd, connection);
			Console.WriteLine($"Кол-во режиссеров:\t{command.ExecuteScalar()}");

			command.CommandText = "SELECT COUNT(*) FROM Movies";
			Console.WriteLine($"Кол-во фильмов:\t\t{command.ExecuteScalar()}");

			command.CommandText = "SELECT last_name FROM Directors WHERE first_name = N'James'";
			Console.WriteLine(command.ExecuteScalar());

			connection.Close();

			Console.WriteLine(Scalar("SELECT last_name FROM Directors WHERE first_name = N'James'")); 
#endif

			//InsertDirector();
			//Select("*", "Directors");

			//InsertMovies();
			Select("movie_name,release_date,first_name+' '+last_name AS director", "Movies, Directors", "director=director_id");
		}
		static void InsertMovies()
		{
			Console.Write("Название фильма: ");
			string movie_name = Console.ReadLine();
			Console.Write("Дата релиза: ");
			string release_date = Console.ReadLine();
			Console.Write("Режиссёр: ");
			string director = Console.ReadLine();

			Insert
				(
				"Movies",
				"movie_id,movie_name,release_date,director",
				$"{Convert.ToInt32(Scalar("SELECT MAX(movie_id) FROM Movies")) + 1},N'{movie_name}','{release_date}', {GetDiretorID(director)}"
				);
		}
		static int GetDiretorID(string full_name)
		{
			return Convert.ToInt32
				(
					Scalar
					(
						$"SELECT director_id FROM Directors WHERE first_name = N'{full_name.Split(' ').First()}' AND last_name = N'{full_name.Split(' ').Last()}'"
					)
				);
		}
		static void InsertDirector()
		{
			Console.Write("Введите имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите фамилию: ");
			string last_name = Console.ReadLine();

			Insert("Directors", "director_id,first_name,last_name",
				$"{Convert.ToInt32(Scalar("SELECT MAX(director_id) FROM Directors")) + 1},N'{first_name}',N'{last_name}'");
		}
		static void Select(string fields, string tables, string condition = "")
		{
			//2) Открываем соединение
			//После того, как подключение создано, оно не является открытым. т.е. подключение всегда открывается в ручную при необходимости
			connection.Open();

			//3) Создаем 'command'
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";

			SqlCommand command = new SqlCommand(cmd, connection);

			//4) Создаем 'Reader'
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				Console.Write(reader.GetName(i) + "\t");
			}
			Console.WriteLine();
			while (reader.Read())
			{
				//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader[i] + "\t\t");
				Console.WriteLine();
			}
			reader.Close();

			//?) Подключение обязательно нужно закрывать
			connection.Close();

		}
		static object Scalar(string cmd)
		{
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			object obj = command.ExecuteScalar();
			connection.Close();
			return obj;
		}
		static void Insert(string table, string fields, string values)
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
			for (int i = 1; i < fields_for_check.Length; i++)
			{
				condition += $" {fields_for_check[i]}={values_for_check[i]} AND";
			}
			condition = condition.Remove(condition.LastIndexOf(' '), 4);
			string cmd = $"IF NOT EXISTS(SELECT {primary_key} FROM {table} WHERE {condition}) BEGIN INSERT {table}({fields}) VALUES ({values}); END";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
	}
}
