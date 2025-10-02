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
using System.Data.SqlClient;
using System.IO;

namespace BestAcademyEver
{
	public partial class TeacherForm : Form
	{
		private MainForm mainForm;
		private MyConnector connector;
		internal int id {  get; set; }
		private byte[] bytes = null;
		public TeacherForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString, "Teachers");
		}
		internal void SelectData()
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				conn.Open();
				string query = "SELECT * FROM Teachers WHERE teacher_id=@id";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							textBoxTeacherForm_lastName.Text = reader["last_name"].ToString();
							textBoxTeacherForm_firstName.Text = reader["first_name"].ToString();
							textBoxTeacherForm_middleName.Text = reader["middle_name"].ToString();
							dtpTeacherForm_birthDate.Text = reader["birth_date"].ToString();
							textBoxTeacherForm_email.Text = reader["email"].ToString();
							textBoxTeacherForm_phone.Text = reader["phone"].ToString();
							dtpTeacherForm_workSince.Text = reader["work_since"].ToString();
							textBoxTeacherForm_rate.Text = reader["rate"].ToString();
							if (reader["photo"] != DBNull.Value)
							{
								bytes = (byte[])reader["photo"];
								using (MemoryStream ms = new MemoryStream(bytes))
									pictureBoxTeacherForm_photo.Image = Image.FromStream(ms);
							}
						}
					}
				}
			}
		}
		internal int InsertData()
		{
			int result = 0;
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				conn.Open();
				string query = "INSERT INTO Teachers (teacher_id,last_name,first_name,middle_name,birth_date,email,phone,photo,work_since,rate) VALUEs (@teacher_id,@last_name,@first_name,@middle_name,@birth_date,@email,@phone,@photo,@work_since,@rate)";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.Add("@teacher_id", SqlDbType.SmallInt).Value = Convert.ToInt32(connector.Scalar("SELECT MAX(teacher_id) FROM Teachers"));
					cmd.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = textBoxTeacherForm_lastName.Text;
					cmd.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = textBoxTeacherForm_firstName.Text;
					cmd.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = textBoxTeacherForm_middleName.Text;
					cmd.Parameters.Add("@birth_date",SqlDbType.Date).Value = dtpTeacherForm_birthDate.Text;
					cmd.Parameters.Add("@email",SqlDbType.NVarChar).Value = textBoxTeacherForm_email.Text;
					cmd.Parameters.Add("@phone",SqlDbType.NChar).Value = textBoxTeacherForm_phone.Text;
					if (bytes != null)
						cmd.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
					else
						cmd.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
					cmd.Parameters.Add("@work_since", SqlDbType.Date).Value = dtpTeacherForm_workSince.Text;
					cmd.Parameters.Add("@rate",SqlDbType.SmallMoney).Value = textBoxTeacherForm_rate.Text;
					result = cmd.ExecuteNonQuery();
				}
			}
			return result;
		}
		internal int UpdateData()
		{
			int result = 0;
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString))
			{
				conn.Open();
				string query = "UPDATE Teachers SET last_name=@last_name,first_name=@first_name,middle_name=@middle_name,birth_date=@birth_date,email=@email,phone=@phone,photo=@photo,work_since=@work_since,rate=@rate WHERE teacher_id=@id";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.Add("@id", SqlDbType.SmallInt).Value = id;
					cmd.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = textBoxTeacherForm_lastName.Text;
					cmd.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = textBoxTeacherForm_firstName.Text;
					cmd.Parameters.Add("@middle_name", SqlDbType.NVarChar).Value = textBoxTeacherForm_middleName.Text;
					cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = dtpTeacherForm_birthDate.Text;
					cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxTeacherForm_email.Text;
					cmd.Parameters.Add("@phone", SqlDbType.NChar).Value = textBoxTeacherForm_phone.Text;
					if (bytes != null)
						cmd.Parameters.Add("@photo", SqlDbType.Image).Value = bytes;
					else
						cmd.Parameters.Add("@photo", SqlDbType.Image).Value = DBNull.Value;
						cmd.Parameters.Add("@work_since", SqlDbType.Date).Value = dtpTeacherForm_workSince.Text;
					cmd.Parameters.Add("@rate", SqlDbType.SmallMoney).Value = textBoxTeacherForm_rate.Text;
					result = cmd.ExecuteNonQuery();
				}
			}
			return result;
		}

		private void buttonTeacherForm_addPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image File|*.bmp;*.png;*.gif;*.jpg";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				bytes = File.ReadAllBytes(ofd.FileName);
				if (bytes != null)
				{
					using (MemoryStream ms = new MemoryStream(bytes))
						pictureBoxTeacherForm_photo.Image = Image.FromStream(ms);
				}
			}
		}
	}
}
