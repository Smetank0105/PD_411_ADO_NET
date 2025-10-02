using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySqlLibrary;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BestAcademyEver
{
	public partial class StudentForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int id {  get; set; }
		private byte[] bytes = null;
		public StudentForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString, "Students");
			comboBoxStudentForm_group.DataSource = connector.Select("SELECT group_id, group_name FROM Groups");
			comboBoxStudentForm_group.DisplayMember = "group_name";
			comboBoxStudentForm_group.ValueMember = "group_id";
		}
		internal void SelectData()
		{
			using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				connection.Open();
				string cmd = "SELECT * FROM Students WHERE stud_id=@stud_id";
				using (SqlCommand command = new SqlCommand(cmd, connection))
				{
					command.Parameters.Add("@stud_id", SqlDbType.Int).Value = id;
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							textBoxStudentForm_lastName.Text = reader["last_name"].ToString();
							textBoxStudentForm_firstName.Text = reader["first_name"].ToString();
							textBoxStudentForm_middleName.Text = reader["middle_name"].ToString();
							dtpStudentForm_birthDate.Text = reader["birth_date"].ToString();
							textBoxStudentForm_email.Text = reader["email"].ToString();
							textBoxStudentForm_phone.Text = reader["phone"].ToString();
							comboBoxStudentForm_group.SelectedValue = reader["group"].ToString();
							if (reader["photo"] != DBNull.Value)
							{
								bytes = (byte[])reader["photo"];
								using (MemoryStream ms = new MemoryStream(bytes))
									pictureBoxStudentForm_photo.Image = Image.FromStream(ms);
							}
						}
					}
				}
			}
		}
		internal int InsertData()
		{
			int result = 0;
			using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				connection.Open();
				string cmd = "INSERT INTO Students (stud_id,last_name,first_name,middle_name,birth_date,email,phone,photo,[group]) VALUES (@stud_id,@last_name,@first_name,@middle_name,@birth_date,@email,@phone,@photo,@group)";
				using (SqlCommand command = new SqlCommand(cmd, connection))
				{
					command.Parameters.Add("@stud_id", SqlDbType.Int).Value = Convert.ToInt32(connector.Scalar("SELECT MAX(stud_id) FROM Students"));
					command.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = textBoxStudentForm_lastName.Text;
					command.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = textBoxStudentForm_firstName.Text;
					command.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = textBoxStudentForm_middleName.Text;
					command.Parameters.Add("@birth_date",SqlDbType.Date).Value = dtpStudentForm_birthDate.Text;
					command.Parameters.Add("@email",SqlDbType.NVarChar).Value = textBoxStudentForm_email.Text;
					command.Parameters.Add("@phone",SqlDbType.NChar).Value = textBoxStudentForm_phone.Text;
					command.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
					command.Parameters.Add("@group", SqlDbType.Int).Value = comboBoxStudentForm_group.SelectedValue;
					result = command.ExecuteNonQuery();
				}
			}
			return result;
		}
		internal int UpdateData()
		{
			int result = 0;
			using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				connection.Open();
				string cmd = "UPDATE Students SET last_name=@last_name,first_name=@first_name,middle_name=@middle_name,birth_date=@birth_date,email=@email,phone=@phone,photo=@photo,[group]=@group WHERE stud_id=@stud_id";
				using (SqlCommand command = new SqlCommand(cmd, connection))
				{
					command.Parameters.Add("@stud_id", SqlDbType.Int).Value = id;
					command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = textBoxStudentForm_lastName.Text;
					command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = textBoxStudentForm_firstName.Text;
					command.Parameters.Add("@middle_name", SqlDbType.NVarChar).Value = textBoxStudentForm_middleName.Text;
					command.Parameters.Add("@birth_date", SqlDbType.Date).Value = dtpStudentForm_birthDate.Text;
					command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxStudentForm_email.Text;
					command.Parameters.Add("@phone", SqlDbType.NChar).Value = textBoxStudentForm_phone.Text;
					command.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
					command.Parameters.Add("@group", SqlDbType.Int).Value = comboBoxStudentForm_group.SelectedValue;
					result = command.ExecuteNonQuery();
				}
			}
			return result;
		}
		private void buttonStudentForm_addPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image File|*.bmp;*.gif;*.jpg;*.png";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				bytes = File.ReadAllBytes(ofd.FileName);
				if (bytes != null)
				{
					using (MemoryStream ms = new MemoryStream(bytes))
						pictureBoxStudentForm_photo.Image = Image.FromStream(ms);
				}
			}
		}
	}
}
