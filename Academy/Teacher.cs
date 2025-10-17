using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DBtools;

namespace Academy
{
	internal class Teacher
	{
		Connector connector;
		public string Last_name { get; set; }
		public string First_name { get; set; }
		public string Middle_name { get; set; }
		public string Birth_date { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public byte[] Photo { get; set; }
		public string Work_since {  get; set; }
		public decimal Rate {  get; set; }
		public Teacher()
		{
			connector = new Connector();
		}
		public Teacher(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo, string work_since, decimal rate)
		{
			connector = new Connector();
			Last_name = last_name;
			First_name = first_name;
			Middle_name = middle_name;
			Birth_date = birth_date;
			Email = email;
			Phone = phone;
			Photo = SerializePhoto(photo);
			Work_since = work_since;
			Rate = rate;
		}
		byte[] SerializePhoto(Image image)
		{
			MemoryStream ms = new MemoryStream();
			image.Save(ms, image.RawFormat);
			return ms.ToArray();
		}
		public void Insert()
		{
			SqlCommand command = new SqlCommand();
			command.Parameters.Add("@teacher_id", SqlDbType.SmallInt).Value =(Convert.ToInt32(connector.Scalar("SELECT MAX(teacher_id) FROM Teachers")) + 1);
			command.Parameters.Add("@last_name", SqlDbType.NVarChar, 50).Value = Last_name;
			command.Parameters.Add("@first_name", SqlDbType.NVarChar, 50).Value = First_name;
			command.Parameters.Add("@middle_name", SqlDbType.NVarChar, 50).Value = Middle_name;
			command.Parameters.Add("@birth_date", SqlDbType.Date).Value = Birth_date;
			command.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Email;
			command.Parameters.Add("@phone", SqlDbType.NChar, 16).Value = Phone;
			command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = Photo;
			command.Parameters.Add("@work_since", SqlDbType.Date).Value = Work_since;
			command.Parameters.Add("@rate", SqlDbType.SmallMoney).Value = Rate;
			connector.Insert("Teachers", command);
		}
		public void Update(int id)
		{
			SqlCommand command = new SqlCommand();
			command.Parameters.Add("@last_name", SqlDbType.NVarChar, 50).Value = Last_name;
			command.Parameters.Add("@first_name", SqlDbType.NVarChar, 50).Value = First_name;
			command.Parameters.Add("@middle_name", SqlDbType.NVarChar, 50).Value = Middle_name;
			command.Parameters.Add("@birth_date", SqlDbType.Date).Value = Birth_date;
			command.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = Email;
			command.Parameters.Add("@phone", SqlDbType.NChar, 16).Value = Phone;
			command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = Photo;
			command.Parameters.Add("@work_since", SqlDbType.Date).Value = Work_since;
			command.Parameters.Add("@rate", SqlDbType.SmallMoney).Value = Rate;
			connector.Update("Teachers", $"teacher_id={id}", command);
		}
		public void Select(int id)
		{
			string cmd = $"SELECT * FROM Teachers WHERE teacher_id={id}";
			DataTable table = new DataTable();
			using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
				adapter.Fill(table);
			}
			Last_name = table.Rows[0][1].ToString();
			First_name = table.Rows[0][2].ToString();
			Middle_name = table.Rows[0][3].ToString();
			Birth_date = table.Rows[0][4].ToString();
			Email = table.Rows[0][5].ToString();
			Phone = table.Rows[0][6].ToString();
			Photo = table.Rows[0][7] as byte[];
			Work_since = table.Rows[0][8].ToString();
			try
			{
				Rate = Convert.ToDecimal(table.Rows[0][9]);
			}
			catch (Exception) { }
		}
	}
}
