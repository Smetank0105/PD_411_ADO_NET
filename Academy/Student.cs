using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBtools;

namespace Academy
{
	internal class Student : Human
	{
		public int ID { get; set; }
		public int Group { get; set; }
		public Student() { }
		public Student(int stud_id)
		{
			Connector connector = new Connector();
			DataTable table = connector.Select("*", "Students", $"stud_id={stud_id}");
			ID = stud_id;
			Last_name = table.Rows[0][1].ToString();
			First_name = table.Rows[0][2].ToString();
			Middle_name = table.Rows[0][3].ToString();
			Birth_date = table.Rows[0][4].ToString();
			Email = table.Rows[0][5].ToString();
			Phone = table.Rows[0][6].ToString();
			Group = Convert.ToInt32(table.Rows[0][8]);
			try { Photo = connector.LoadPhoto(stud_id, "Students", "photo"); }
			catch (Exception ex) { }
		}
		public Student(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, int group, Image photo)
			:base(last_name,first_name,middle_name,birth_date,email,phone,photo)
		{
			Group = group;
		}
		public override string ToString()
		{
			return $"{base.ToString()},{Group}";
		}
		public override string ToStringUpdate()
		{
			return $"{base.ToStringUpdate()},[group]={Group}";
		}
	}
}
