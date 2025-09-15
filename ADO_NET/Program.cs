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
		static void Main(string[] args)
		{
			//1) Создаем подключчение к Базе Данны на Сервере
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			Console.WriteLine(connectionString);
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			//2) Открываем соединение
			//После того, как подключение создано, оно не является открытым. т.е. подключение всегда открывается в ручную при необходимости
			connection.Open();

			//3) Создаем 'DataReader'
			string cmd = "SELECT * FROM Directors";
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
				for(int i=0; i < reader.FieldCount;i++)
					Console.Write(reader[i]+"\t\t");
				Console.WriteLine();
			}
			reader.Close();

			//?) Подключение обязательно нужно закрывать
			connection.Close();
		}
	}
}
