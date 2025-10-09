using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class FormTeacher : Form
	{
		internal Teacher teacher { get; set; }
		public FormTeacher()
		{
			InitializeComponent();
		}
		public FormTeacher(int id) : this()
		{
			teacher = new Teacher();
			teacher.Select(id);
			textBoxLastName.Text = teacher?.Last_name;
			textBoxFirstName.Text = teacher?.First_name;
			textBoxMiddleName.Text = teacher?.Middle_name;
			dateTimePickerBirthDate.Text = teacher?.Birth_date;
			textBoxEmail.Text = teacher?.Email;
			textBoxPhone.Text = teacher?.Phone;
			dateTimePickerWorkSince.Text = teacher?.Work_since;
			textBoxRate.Text = teacher?.Rate.ToString();
			labelID.Visible = true;
			labelID.Text = $"ID: {id}";
			try
			{
				MemoryStream ms = new MemoryStream(teacher?.Photo);
				pictureBoxPhoto.Image = Image.FromStream(ms);
			}
			catch (Exception) { }
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			teacher = new Teacher
				(
				textBoxLastName.Text,
				textBoxFirstName.Text,
				textBoxMiddleName.Text,
				dateTimePickerBirthDate.Text,
				textBoxEmail.Text,
				textBoxPhone.Text,
				pictureBoxPhoto.Image,
				dateTimePickerWorkSince.Text,
				Convert.ToDecimal(textBoxRate.Text)
				);
		}

		private void buttonBrowsPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image files|*.png;*.jpg;*.bmp;*.gif|All files|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
			}
		}
	}
}
