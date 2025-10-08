using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace Academy
{
	internal class Teacher
	{
		Connector connector;
		public short Teacher_id { get; set; }
		public string Last_name { get; set; }
		public string First_name { get; set; }
		public string Middle_name { get; set; }
		public string Birth_date { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public byte[] Photo { get; set; }
		public string Work_since {  get; set; }
		public decimal Rate {  get; set; }
		public Teacher(short teacher_id, string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo, string work_since, decimal rate)
		{
			connector = new Connector();
			Teacher_id = teacher_id;
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
			command.Parameters.Add("@teacher_id", SqlDbType.SmallInt).Value = Teacher_id;
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
		public void Update()
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
			connector.Update("Teachers", $"teacher_id={Teacher_id}", command);
		}
	}
}
