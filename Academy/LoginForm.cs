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
	public partial class LoginForm : Form
	{
		public string Login {  get; set; }
		public string Password { get; set; }
		public string IP {  get; set; }
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Login = textBoxLogin.Text;
			Password = textBoxPassword.Text;
			IP = textBoxIP.Text;
		}
	}
}
