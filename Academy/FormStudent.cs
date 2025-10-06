using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class FormStudent : Form
	{
		internal Student student {  get; set; }
		Connector connector;
		public FormStudent()
		{
			InitializeComponent();
			connector = new Connector();
			DataTable groups = connector.Select("*", "Groups");
			comboBoxGroup.DataSource = groups;
			comboBoxGroup.DisplayMember = "group_name";
			comboBoxGroup.ValueMember = "group_id";

			InitForm();
		}
		public FormStudent(int stud_id) : this()
		{
			DataTable table = connector.Select("*", "Students", $"stud_id={stud_id}");
			textBoxLastName.Text = table.Rows[0][1].ToString();
			textBoxFirstName.Text = table.Rows[0][2].ToString();
			textBoxMiddleName.Text = table.Rows[0][3].ToString();
			dateTimePickerBirthDate.Text = table.Rows[0][4].ToString();
			textBoxEmail.Text = table.Rows[0][5].ToString();
			textBoxPhone.Text = table.Rows[0][6].ToString();
			comboBoxGroup.SelectedValue = table.Rows[0][8];
			labelID.Visible = true;
			labelID.Text = $"ID: {table.Rows[0][0].ToString()}";
		}
		void InitForm()
		{
			textBoxLastName.Text = "Иванов";
			textBoxFirstName.Text = "Иван";
			textBoxMiddleName.Text = "Иванович";
			dateTimePickerBirthDate.Text = "2007-07-08";
			textBoxEmail.Text = "ivanov@mail.ru";
			textBoxPhone.Text = "+7(123)456-77-88";
			comboBoxGroup.SelectedValue = 11;
		}
		void Compress()
		{
			student.Last_name = textBoxLastName.Text;
			student.First_name = textBoxFirstName.Text;
			student.Middle_name = textBoxMiddleName.Text;
			student.Birth_date = dateTimePickerBirthDate.Text;
			student.Email = textBoxEmail.Text;
			student.Phone = textBoxPhone.Text;
			student.Group = Convert.ToInt32(comboBoxGroup.SelectedValue);
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			student = new Student
				(
				textBoxLastName.Text,
				textBoxFirstName.Text,
				textBoxMiddleName.Text,
				dateTimePickerBirthDate.Text,
				textBoxEmail.Text,
				textBoxPhone.Text,
				Convert.ToInt32(comboBoxGroup.SelectedValue)
				);
		}
	}
}
