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
using System.Runtime.InteropServices;
using System.Configuration;

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString = "";
		SqlConnection connection;
		Connector connector;
		Dictionary<string, int> d_groupDirection;
		Dictionary<string, int> d_studentGroup;

		Query[] queries = new Query[]
		{
			new Query
			(
			"stud_id,FORMATMESSAGE(N'%s,%s,%s',last_name,first_name,middle_name) AS N'Студент',group_name AS N'Группа',direction_name AS N'Направление'",
			"Students,Groups,Directions",
			"[group]=group_id AND direction=direction_id"
			),
			new Query
			(
			"group_id, group_name,learning_days,start_time,direction_name",
			"Groups,Directions",
			"direction=direction_id"
			),
			new Query("*","Directions"),
			new Query("*","Disciplines"),
			new Query("*","Teachers")
		};

		readonly string[] statusBarMessages = new string[]
		{
			"Количество студентов",
			"Количество групп",
			"Количество направлений",
			"Количество дисциплин",
			"Количество преподавателей",
		};
		public MainForm()
		{
			InitializeComponent();
			AllocConsole();
			connectionString = ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString;
			connection = new SqlConnection(connectionString);
			connector = new Connector();
			Console.WriteLine(tabControl.TabCount);
			d_groupDirection = LoadDataToComboBox("*","Directions");
			comboBoxGroupsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			comboBoxStudentsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			comboBoxGroupsDirection.SelectedIndex = 0;
			comboBoxStudentsDirection.SelectedIndex = 0;
			tabControl.SelectedIndex = 2;
			for(int i = 0; i < tabControl.TabCount; i++)
				(this.Controls.Find($"dataGridView{tabControl.TabPages[i].Name.Remove(0, "tabPage".Length)}",true)[0] as DataGridView).RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridViewChanged);

		}
		void LoadTab(int i)
		{
			string tableName = tabControl.TabPages[i].Name.Remove(0,"tabPage".Length);
			DataGridView dataGridView = this.Controls.Find($"dataGridView{tableName}", true)[0] as DataGridView;
			dataGridView.DataSource = connector.Select(queries[i].Fileds, queries[i].Tables, queries[i].Condition);
			if (i == 1) ConvertLearningDays();
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.ReadOnly = true;
		}
		//DataTable Select(string fields, string tables, string condition="")
		//{
		//	DataTable table = new DataTable();
		//	string cmd = $"SELECT {fields} FROM {tables}";
		//	if (!string.IsNullOrWhiteSpace(condition)) cmd += $" WHERE {condition}";
		//	cmd += ";";
		//	SqlCommand command = new SqlCommand(cmd, connection);
		//	connection.Open();
		//	SqlDataReader reader = command.ExecuteReader();
		//	for(int i = 0; i < reader.FieldCount; i++)
		//	{
		//		table.Columns.Add(reader.GetName(i));
		//	}
		//	while (reader.Read())
		//	{
		//		DataRow row = table.NewRow();
		//		for(int i = 0; i < reader.FieldCount; i++)
		//		{
		//			row[i] = reader[i];
		//		}
		//		table.Rows.Add(row);
		//	}
		//	reader.Close();
		//	connection.Close();
		//	return table;
		//}
		//void Insert(string table, string fields, string values)
		//{
		//	string cmd = $"INSERT {table} ({fields}) VALUES ({values})";
		//	SqlCommand command = new SqlCommand(cmd, connection);
		//	connection.Open();
		//	command.ExecuteNonQuery();
		//	connection.Close();
		//}
		void ConvertLearningDays()
		{
			for(int i = 0; i < dataGridViewGroups.RowCount; i++)
			{
				dataGridViewGroups.Rows[i].Cells["learning_days"].Value = new Week(Convert.ToByte(dataGridViewGroups.Rows[i].Cells["learning_days"].Value));
			}
		}
		Dictionary<string,int> LoadDataToComboBox(string fields, string tables)
		{
			Dictionary<string,int> dictionary = new Dictionary<string,int>();
			dictionary.Add("Все", 0);
			string cmd = $"SELECT {fields} FROM {tables}";
			SqlCommand command = new SqlCommand (cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				dictionary.Add(reader[1].ToString(), Convert.ToInt32(reader[0]));
			}
			reader.Close();
			connection.Close();
			return dictionary;
		}

		private void comboBoxGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			string condition = $"direction=direction_id";
			if (comboBoxGroupsDirection.SelectedItem.ToString() != "Все") condition += $" AND direction={d_groupDirection[comboBoxGroupsDirection.SelectedItem.ToString()]}";
			dataGridViewGroups.DataSource = connector.Select("group_id,group_name,direction","Groups,Directions",condition);
		}
		[DllImport("Kernel32.dll")]
		static extern void AllocConsole();

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadTab((sender as TabControl).SelectedIndex);
		}
		private void dataGridViewChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = $"{statusBarMessages[tabControl.SelectedIndex]}: {(sender as DataGridView).RowCount - 1}";
		}

		private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			string condition = "Groups";
			if (comboBoxStudentsDirection.SelectedItem.ToString() != "Все") condition += $" WHERE direction={d_groupDirection[comboBoxStudentsDirection.SelectedItem.ToString()]}";
			d_studentGroup = LoadDataToComboBox("*", condition);
			comboBoxStudentsGroup.Items.Clear();
			comboBoxStudentsGroup.Items.AddRange(d_studentGroup.Keys.ToArray());
			comboBoxStudentsGroup.SelectedIndex = 0;

			condition = queries[0].Condition;
			if (comboBoxStudentsDirection.SelectedItem.ToString() != "Все") condition += $" AND direction={d_groupDirection[comboBoxStudentsDirection.SelectedItem.ToString()]}";
			dataGridViewStudents.DataSource = connector.Select(queries[0].Fileds, queries[0].Tables, condition);
		}

		private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			string condition = queries[0].Condition;
			if (comboBoxStudentsGroup.SelectedItem.ToString() != "Все") condition += $" AND [group]={d_studentGroup[comboBoxStudentsGroup.SelectedItem.ToString()]}";
			dataGridViewStudents.DataSource = connector.Select(queries[0].Fileds, queries[0].Tables, condition);
		}

		private void buttonAddStudent_Click(object sender, EventArgs e)
		{
			FormStudent student = new FormStudent();
			DialogResult result = student.ShowDialog();
			if (result == DialogResult.OK)
			{
				connector.Insert
					(
					"Students",
					"last_name,first_name,middle_name,birth_date,email,phone,[group]",
					student.student.ToString()
					);
				int id = Convert.ToInt32(connector.Scalar("SELECT MAX(stud_id) FROM Students"));
				connector.UploadPhoto(student.student.Photo, id, "photo", "Students");
			}
		}

		private void dataGridViewStudents_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int i = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells[0].Value);
			FormStudent form = new FormStudent(i);
			DialogResult result =  form.ShowDialog();
			if (result == DialogResult.OK)
			{
				connector.Update
					(
					"Students",
					form.student.ToStringUpdate(),
					$"stud_id={i}"
					);
				connector.UploadPhoto(form.student.Photo, i, "photo", "Students");
				comboBoxStudentsGroup_SelectedIndexChanged(null, null);
			}
		}

		private void dataGridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridViewTeachers.Rows[e.RowIndex];
				int id = Convert.ToInt32(selectedRow.Cells[0].Value);
				FormTeacher form = new FormTeacher(id);
				if (form.ShowDialog() == DialogResult.OK)
					form.teacher.Update(id);
				LoadTab(4);
			}
		}

		private void buttonAddTeacher_Click(object sender, EventArgs e)
		{
			FormTeacher form = new FormTeacher();
			if (form.ShowDialog() == DialogResult.OK)
				form.teacher.Insert();
			LoadTab(4);
		}
	}
}
