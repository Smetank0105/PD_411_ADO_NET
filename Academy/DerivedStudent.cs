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
	public partial class DerivedStudent : BaseHumanForm
	{
		public DerivedStudent()
		{
			InitializeComponent();
			DataTable groups = connector.Select("*", "Groups");
			comboBoxGroup.DataSource = groups;
			comboBoxGroup.DisplayMember = "group_name";
			comboBoxGroup.ValueMember = "group_id";
		}
		public DerivedStudent(int id):this()
		{
			Human = new Student(id);
			Extract();
		}
		protected override void Extract()
		{
			base.Extract();
			comboBoxGroup.SelectedValue = (Human as Student).Group;
			labelID.Visible = true;
			labelID.Text = $"ID: {(Human as Student).ID.ToString()}";
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			Human = new Student
				(
				textBoxLastName.Text,
				textBoxFirstName.Text,
				textBoxMiddleName.Text,
				dateTimePickerBirthDate.Text,
				textBoxEmail.Text,
				textBoxPhone.Text,
				Convert.ToInt32(comboBoxGroup.SelectedValue),
				pictureBoxPhoto.Image
				);
		}
	}
}
