using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DBtools;

namespace Academy
{
	internal class TeacherClass : Human
	{
		public int ID { get; set; }
		public string Work_since { get; set; }
		public string Rate { get; set; }
		public TeacherClass() { }
		public TeacherClass(int teacher_id)
		{
			Connector connector = new Connector();
			DataTable table = connector.Select("*", "Teachers", $"teacher_id={teacher_id}");
			ID = teacher_id;
			Last_name = table.Rows[0][1].ToString();
			First_name = table.Rows[0][2].ToString();
			Middle_name = table.Rows[0][3].ToString();
			Birth_date = table.Rows[0][4].ToString();
			Email = table.Rows[0][5].ToString();
			Phone = table.Rows[0][6].ToString();
			try { Photo = connector.LoadPhoto(teacher_id, "Teachers", "photo"); }
			catch (Exception) { }
			Work_since = table.Rows[0][8].ToString();
			Rate = table.Rows[0][9].ToString();
		}
		public TeacherClass(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo, string work_since, string rate)
			: base(last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			Work_since=work_since;
			Rate=rate;
		}
		public override string ToString()
		{
			return $"{base.ToString()},'{Work_since}',{Rate}";
		}
		public override string ToStringUpdate()
		{
			return $"{base.ToStringUpdate()},work_since='{Work_since}',rate={Rate}";
		}
	}
}
