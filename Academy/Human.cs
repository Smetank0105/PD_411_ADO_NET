using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy
{
	internal class Human
	{
		public string Last_name { get; set; }
		public string First_name { get; set; }
		public string Middle_name { get; set; }
		public string Birth_date { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public Image Photo { get; set; }
		public Human() { }
		public Human(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo)
		{
			Last_name = last_name;
			First_name = first_name;
			Middle_name = middle_name;
			Birth_date = birth_date;
			Email = email;
			Phone = phone;
			Photo = photo;
		}
		public byte[] SerializePhoto()
		{
			MemoryStream ms = new MemoryStream();
			Photo.Save(ms, Photo.RawFormat);
			return ms.ToArray();
		}
		public override string ToString()
		{
			return $"N'{Last_name}',N'{First_name}',N'{Middle_name}','{Birth_date}',N'{Email}',N'{Phone}'";
		}
		public virtual string ToStringUpdate()
		{
			return $@"last_name=N'{Last_name}',
first_name=N'{First_name}',
middle_name=N'{Middle_name}',
birth_date='{Birth_date}',
email=N'{Email}',
phone=N'{Phone}'";
		}
	}
}
