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
