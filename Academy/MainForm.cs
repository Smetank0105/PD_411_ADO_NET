using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString = "Data Source=SMETANK\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		SqlConnection connection;
		public MainForm()
		{
			InitializeComponent();
			connection = new SqlConnection(connectionString);

			dataGridViewStudents.DataSource = LoadTable("Students");
			dataGridViewGroups.DataSource = LoadTable("Groups");
			dataGridViewDirections.DataSource = LoadTable("Directions");
			dataGridViewDisciplines.DataSource = LoadTable("Disciplines");
			dataGridViewTeachers.DataSource = LoadTable("Teachers");

			toolStripStatusLabel.Text = LoadRowCount("Students");
		}
		DataTable LoadTable(string table_name)
		{
			string cmd = $"SELECT * FROM {table_name};";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
					row[i] = reader[i];
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			return table;
		}
		string LoadRowCount(string table_name)
		{
			string cmd = $"SELECT COUNT(*) FROM {table_name};";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open ();
			string result = command.ExecuteScalar().ToString();
			connection.Close ();
			return $"Кол-во записей в таблице {table_name}: " + result;
		}
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0: toolStripStatusLabel.Text = LoadRowCount("Students"); break;
				case 1: toolStripStatusLabel.Text = LoadRowCount("Groups"); break;
				case 2: toolStripStatusLabel.Text = LoadRowCount("Directions"); break;
				case 3: toolStripStatusLabel.Text = LoadRowCount("Disciplines"); break;
				case 4: toolStripStatusLabel.Text = LoadRowCount("Teachers"); break;
			}
		}
	}
}
