//#define SCALAR_CHECK
//#define INSERCT_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET
using System.Data.SqlClient;

namespace ADO_NET
{
	class Program
	{
		static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		static SqlConnection connection;
		static void Main(string[] args)
		{
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

#if INSERT_CHECK
			Console.Write("Введите имя: ");
			string first_name = Console.ReadLine();
			Console.WriteLine("Введите фамилию: ");
			string last_name = Console.ReadLine();

			string cmd = $"INSERT Directors(director_id,first_name,last_name) VALUES ({Convert.ToInt32(Scalar("SELECT MAX(director_id) FROM Directors")) + 1},N'{first_name}',N'{last_name}')";

			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();

			connection.Close();
			Select("*", "Directors"); 
#endif
			//Insert("Directors (director_id,first_name,last_name)", "13, N'Christopher', N'Nolan'");
			//Insert("Movies (movie_id,movie_name,release_date,director)", "10, N'Inception', '2010-07-22', 13");
			Select("*", "Directors");
			Select("movie_name,first_name+' '+last_name AS director", "Movies, Directors", "director=director_id");
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
		static void Insert(string table, string values)
		{
			connection.Open();
			string cmd = $"INSERT {table} VALUES ({values})";
			SqlCommand command = new SqlCommand(cmd, connection);
			Console.WriteLine($"Кол-во измененных строк:\t{command.ExecuteNonQuery()}");
			connection.Close();
		}
	}
}
