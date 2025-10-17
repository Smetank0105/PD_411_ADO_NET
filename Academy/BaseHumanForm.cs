using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBtools;

namespace Academy
{
	public partial class BaseHumanForm : Form
	{
		internal Human Human {  get; set; }
		internal Connector connector;
		public BaseHumanForm()
		{
			InitializeComponent();
			connector = new Connector();
			buttonBrowsPhoto.Click += buttonBrowsPhoto_Click;
			buttonOk.Click += buttonOk_Click;
		}
		protected virtual void Extract()
		{
			textBoxLastName.Text = Human.Last_name;
			textBoxFirstName.Text = Human.First_name;
			textBoxMiddleName.Text = Human.Middle_name;
			dateTimePickerBirthDate.Text = Human.Birth_date;
			textBoxEmail.Text = Human.Email;
			textBoxPhone.Text = Human.Phone;
			pictureBoxPhoto.Image = Human.Photo;
			labelID.Visible = true;
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

		protected virtual void buttonOk_Click(object sender, EventArgs e)
		{

		}
	}
}
