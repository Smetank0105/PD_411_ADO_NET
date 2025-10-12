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
	public partial class DerivedTeacher : BaseHumanForm
	{
		public DerivedTeacher()
		{
			InitializeComponent();
		}
		public DerivedTeacher(int id) : this()
		{
			Human = new TeacherClass(id);
			Extract();
		}
		protected override void Extract()
		{
			base.Extract();
			dateTimePickerWorkSince.Text = (Human as TeacherClass).Work_since;
			textBoxRate.Text = (Human as TeacherClass).Rate;
			labelID.Visible = true;
			labelID.Text = $"ID: {(Human as TeacherClass).ID.ToString()}";
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			Human = new TeacherClass
				(
				textBoxLastName.Text,
				textBoxFirstName.Text,
				textBoxMiddleName.Text,
				dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd"),
				textBoxEmail.Text,
				textBoxPhone.Text,
				pictureBoxPhoto.Image,
				dateTimePickerWorkSince.Text,
				Convert.ToDecimal(textBoxRate.Text).ToString(".")
				);
		}
	}
}
