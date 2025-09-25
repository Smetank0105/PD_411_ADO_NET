using MySqlLibrary;
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
	public partial class StudentForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int stud_id { get; set; }
		public StudentForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(this.mainForm.connectionString, "Students");
			comboBoxStudent_group.Items.AddRange(this.mainForm.LoadDataToComboBox("*", "Groups").Keys.ToArray());
		}
		internal void LoadStudentData()
		{
			DataTable table = MyConnector.Select(this.mainForm.connectionString, $"SELECT * FROM Students WHERE stud_id={this.stud_id}");
			textBoxStudent_lastName.Text = table.Rows[0]["last_name"].ToString();
			textBoxStudent_firstName.Text = table.Rows[0]["first_name"].ToString();
			textBoxStudent_middleName.Text = table.Rows[0]["middle_name"].ToString();
			dateTimePickerStudent_birthDate.Text = table.Rows[0]["birth_date"].ToString();
			textBoxStudent_email.Text = table.Rows[0]["email"].ToString();
			textBoxStudent_phone.Text = table.Rows[0]["phone"].ToString();

			comboBoxStudent_group.SelectedIndex = Convert.ToInt32(table.Rows[0]["group"]);
		}
		internal string UploadStudentData()
		{
			string cmd = $"N'{textBoxStudent_lastName.Text.Trim()}',N'{textBoxStudent_firstName.Text.Trim()}','{textBoxStudent_middleName.Text.Trim()}','{dateTimePickerStudent_birthDate.Text}',N'{textBoxStudent_email.Text.Trim()}','{textBoxStudent_phone.Text.Trim()}',,{comboBoxStudent_group.SelectedIndex}";
			return cmd;
		}
	}
}
