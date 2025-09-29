using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlLibrary;

namespace Academy
{
	public partial class TeacherForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int teacher_id { get; set; }
		public TeacherForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(this.mainForm.connectionString, "Teachers");
		}
		internal void LoadTeacherData()
		{
			DataTable table = MyConnector.Select(this.mainForm.connectionString, $"SELECT * FROM Teachers WHERE teacher_id={this.teacher_id}");
			textBoxTeachers_lastName.Text = table.Rows[0]["last_name"].ToString();
			textBoxTeachers_firstName.Text = table.Rows[0]["first_name"].ToString();
			textBoxTeachers_middleName.Text = table.Rows[0]["middle_name"].ToString();
			dateTimePickerTeachers_birthDate.Text = table.Rows[0]["birth_date"].ToString();
			textBoxTeachers_email.Text = table.Rows[0]["email"].ToString();
			textBoxTeachers_phone.Text = table.Rows[0]["phone"].ToString();

			dateTimePickerTeachers_workSince.Text = table.Rows[0]["work_since"].ToString();
			textBoxTeachers_rate.Text = table.Rows[0]["rate"].ToString();
		}
		internal string UploadTeacherData()
		{
			string cmd = $"N'{textBoxTeachers_lastName.Text.Trim()}',N'{textBoxTeachers_firstName.Text.Trim()}','{textBoxTeachers_middleName.Text.Trim()}','{dateTimePickerTeachers_birthDate.Text}',N'{textBoxTeachers_email.Text.Trim()}','{textBoxTeachers_phone.Text.Trim()}',,'{dateTimePickerTeachers_workSince.Text}', {textBoxTeachers_rate.Text}";
			return cmd;
		}
	}
}
