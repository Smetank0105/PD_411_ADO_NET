using MySqlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		internal string connectionString = "Data Source=SMETANK\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		SqlConnection connection;
		internal Dictionary<string, int> d_groupDirection;
		internal Dictionary<string, int> d_studentGroup;
		internal Dictionary<string, int> d_studentDirection;
		private bool suspendEvetns = false;
		public MainForm()
		{
			InitializeComponent();
			connection = new SqlConnection(connectionString);
			//LoadDirections();
			//LoadGroups();
			//dataGridViewDirections.DataSource = Select("*","Directions");
			dataGridViewDirections.DataSource = Select(" direction_id AS N'ID', direction_name AS N'Направление обучения', COUNT(group_id) AS N'Кол-во групп'", "Groups RIGHT JOIN Directions ON (direction=direction_id) GROUP BY direction_id,direction_name");
			dataGridViewGroups.DataSource = Select("group_id AS N'ID Группы',group_name AS N'Название Группы',direction AS N'Направление'","Groups,Directions","direction=direction_id");
			dataGridViewStudents.DataSource = Select("stud_id, last_name+' '+first_name+' '+middle_name AS N'ФИО студента', birth_date AS N'Дата рождения', [group] AS N'ID Группы', direction_name AS N'Направление'", "Students,Groups,Directions", "[group]=group_id AND direction=direction_id");
			d_groupDirection = LoadDataToComboBox("*","Directions");
			comboBoxGroupsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			d_studentGroup = LoadDataToComboBox("*", "Groups");
			comboBoxStudentsGtoup.Items.AddRange(d_studentGroup.Keys.ToArray());
			d_studentDirection = LoadDataToComboBox("*", "Directions");
			comboBoxStudentsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			suspendEvetns = true;
			comboBoxGroupsDirection.SelectedIndex = 0;
			comboBoxStudentsGtoup.SelectedIndex = 0;
			comboBoxStudentsDirection.SelectedIndex = 0;
			suspendEvetns = false;
		}
		DataTable Select(string fields, string tables, string condition="")
		{
			DataTable table = new DataTable();
			string cmd = $"SELECT {fields} FROM {tables}";
			if (!string.IsNullOrWhiteSpace(condition)) cmd += $" WHERE {condition}";
			cmd += ";";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			for(int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for(int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			return table;
		}
		void LoadDirections()
		{
			string cmd = "SELECT direction_id AS N'ID', direction_name AS N'Направление обучения', COUNT(group_id) AS N'Кол-во групп' FROM Groups RIGHT JOIN Directions ON (direction=direction_id) GROUP BY direction_id,direction_name;";
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
			dataGridViewDirections.DataSource = table;
		}
		void LoadGroups()
		{
			string cmd = "SELECT group_id AS N'ID',group_name AS N'Группа',COUNT(stud_id) AS N'Кол-во студентов',direction_name AS N'Направление обучения' FROM Students RIGHT JOIN Groups ON ([group]=group_id) JOIN Directions ON (direction=direction_id) GROUP BY group_id,group_name,direction_name;";
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
			dataGridViewGroups.DataSource = table;
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
				//comboBoxGroupsDirection.Items.Add(reader[1]);
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
			dataGridViewGroups.DataSource = Select("group_id AS N'ID Группы',group_name AS N'Название Группы',direction AS N'Направление'", "Groups,Directions",condition);
		}
		private void comboBoxStudentGtoups_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!suspendEvetns)
			{
				string condition = $"[group]=group_id AND direction=direction_id";
				if (comboBoxStudentsGtoup.SelectedItem.ToString() != "Все") condition += $" AND [group]={d_studentGroup[comboBoxStudentsGtoup.SelectedItem.ToString()]}";
				if (comboBoxStudentsDirection.SelectedItem.ToString() != "Все") condition += $" AND direction={d_studentDirection[comboBoxStudentsDirection.SelectedItem.ToString()]}";
				dataGridViewStudents.DataSource = Select("stud_id, last_name+' '+first_name+' '+middle_name AS N'ФИО студента', birth_date AS N'Дата рождения', [group] AS N'ID Группы', direction_name AS N'Направление'", "Students,Groups,Directions", condition); 
			}
		}
		private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!suspendEvetns)
			{
				string condition = $"[group]=group_id AND direction=direction_id";
				if (comboBoxStudentsGtoup.SelectedItem.ToString() != "Все") condition += $" AND [group]={d_studentGroup[comboBoxStudentsGtoup.SelectedItem.ToString()]}";
				if (comboBoxStudentsDirection.SelectedItem.ToString() != "Все") condition += $" AND direction={d_studentDirection[comboBoxStudentsDirection.SelectedItem.ToString()]}";
				dataGridViewStudents.DataSource = Select("stud_id, last_name+' '+first_name+' '+middle_name AS N'ФИО студента', birth_date AS N'Дата рождения', [group] AS N'ID Группы', direction_name AS N'Направление'", "Students,Groups,Directions", condition); 
			}
		}

		private void dataGridViewGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridViewGroups.Rows[e.RowIndex];
				GroupForm groupForm = new GroupForm(this);
				int result = 0;
				groupForm.group_id = Convert.ToInt32(selectedRow.Cells[0].Value);
				groupForm.LoadGroupData();
				if (groupForm.ShowDialog() == DialogResult.OK)
					result = groupForm.connector_to_Groups.Update(groupForm.UploadGroupData(), $"group_id={groupForm.group_id}");
				if (result > 0)
					MessageBox.Show("Запись обновлена.");
				else
					MessageBox.Show("Обновить запись не удалось!");
			}
			comboBoxGroupsDirection_SelectedIndexChanged(sender, e);
		}

		private void buttonGroupsInsert_Click(object sender, EventArgs e)
		{
			GroupForm groupForm = new GroupForm(this);
			int result = 0;
			string cmd = "";
			if (groupForm.ShowDialog() == DialogResult.OK)
			{
				cmd += (Convert.ToInt32(groupForm.connector_to_Groups.Scalar("SELECT MAX(group_id) FROM Groups")) + 1).ToString() + ",";
				cmd += groupForm.UploadGroupData();
				result = groupForm.connector_to_Groups.Insert(cmd);
			}
			if (result > 0)
				MessageBox.Show("Запись успешна.");
			else
				MessageBox.Show("Произвести запись не удалось!");
			comboBoxGroupsDirection_SelectedIndexChanged(sender, e);
		}
	}
}
