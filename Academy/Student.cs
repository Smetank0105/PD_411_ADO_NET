using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Student
	{
		public string Last_name {  get; set; }
		public string First_name { get; set; }
		public string Middle_name { get; set; }
		public string Birth_date { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Group { get; set; }
		public byte[] Photo { get; set; }
		public Student() { }
		public Student(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, int group)
		{
			Last_name = last_name;
			First_name = first_name;
			Middle_name = middle_name;
			Birth_date = birth_date;
			Email = email;
			Phone = phone;
			Group = group;
		}

		public override string ToString()
		{
			return $"N'{Last_name}',N'{First_name}',N'{Middle_name}','{Birth_date}',N'{Email}',N'{Phone}',{Group}";
		}
	}
}
