using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET
{
	internal class MovieConnector:Connector
	{
		public MovieConnector(string connectionString) : base(connectionString){ }
		public int GetDiretorID(string full_name)
		{
			return Convert.ToInt32
				(
					Scalar
					(
						$"SELECT director_id FROM Directors WHERE first_name = N'{full_name.Split(' ').First()}' AND last_name = N'{full_name.Split(' ').Last()}'"
					)
				);
		}
		public void InsertMovies()
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
		public void InsertDirector()
		{
			Console.Write("Введите имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите фамилию: ");
			string last_name = Console.ReadLine();

			Insert("Directors", "director_id,first_name,last_name",
				$"{Convert.ToInt32(Scalar("SELECT MAX(director_id) FROM Directors")) + 1},N'{first_name}',N'{last_name}'");
		}
		public void SelectDirectors()
		{
			Select("*", "Directors");
		}
		public void SelectMovies()
		{
			Select("movie_name,release_date,first_name+' '+last_name AS director", "Movies, Directors", "director=director_id");
		}
	}
}
