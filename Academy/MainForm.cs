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

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString = "Data Source=SMETANK\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		SqlConnection connection;
		Dictionary<string, int> d_groupDirection;
		Dictionary<string, int> d_studentGroup;
		DataSet DisciplinesRelatedData = null;

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
			connection = new SqlConnection(connectionString);
			Console.WriteLine(tabControl.TabCount);
			d_groupDirection = LoadDataToComboBox("*", "Directions");
			comboBoxGroupsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			comboBoxStudentsDirection.Items.AddRange(d_groupDirection.Keys.ToArray());
			comboBoxGroupsDirection.SelectedIndex = 0;
			comboBoxStudentsDirection.SelectedIndex = 0;
			tabControl.SelectedIndex = 2;
			for (int i = 0; i < tabControl.TabCount; i++)
				(this.Controls.Find($"dataGridView{tabControl.TabPages[i].Name.Remove(0, "tabPage".Length)}", true)[0] as DataGridView).RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridViewChanged);
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			DisciplinesRelatedData = new DataSet(nameof(DisciplinesRelatedData));
			DisciplinesRelatedData.Tables.Add("Disciplines");
			DisciplinesRelatedData.Tables["Disciplines"].Columns.Add("discipline_id");
			DisciplinesRelatedData.Tables["Disciplines"].Columns.Add("discipline_name");
			DisciplinesRelatedData.Tables["Disciplines"].Columns.Add("number_of_lessons");
			DisciplinesRelatedData.Tables["Disciplines"].PrimaryKey = new DataColumn[] { DisciplinesRelatedData.Tables["Disciplines"].Columns["discipline_id"] };
			DisciplinesRelatedData.Tables.Add("Directions");
			DisciplinesRelatedData.Tables["Directions"].Columns.Add("direction_id");
			DisciplinesRelatedData.Tables["Directions"].Columns.Add("direction_name");
			DisciplinesRelatedData.Tables["Directions"].PrimaryKey = new DataColumn[] { DisciplinesRelatedData.Tables["Directions"].Columns["direction_id"] };
			DisciplinesRelatedData.Tables.Add("DisciplinesDirectionsRelation");
			DisciplinesRelatedData.Tables["DisciplinesDirectionsRelation"].Columns.Add("direction");
			DisciplinesRelatedData.Tables["DisciplinesDirectionsRelation"].Columns.Add("discipline");
			DisciplinesRelatedData.Relations.Add
				(
				"DirectionsToDDRdirection",
				DisciplinesRelatedData.Tables["Directions"].Columns["direction_id"],
				DisciplinesRelatedData.Tables["DisciplinesDirectionsRelation"].Columns["direction"]
				);
			DisciplinesRelatedData.Relations.Add
				(
				"DisciplinesToDDRdiscipline",
				DisciplinesRelatedData.Tables["Disciplines"].Columns["discipline_id"],
				DisciplinesRelatedData.Tables["DisciplinesDirectionsRelation"].Columns["discipline"]
				);
			SqlDataAdapter directionsAdapter = new SqlDataAdapter("SELECT * FROM Directions", connection);
			SqlDataAdapter disciplinesAdapter = new SqlDataAdapter("SELECT * FROM Disciplines", connection);
			SqlDataAdapter ddrAdapter = new SqlDataAdapter("SELECT * FROM DisciplinesDirectionsRelation", connection);
			directionsAdapter.Fill(DisciplinesRelatedData.Tables["Directions"]);
			disciplinesAdapter.Fill(DisciplinesRelatedData.Tables["Disciplines"]);
			ddrAdapter.Fill(DisciplinesRelatedData.Tables["DisciplinesDirectionsRelation"]);

			DataTable comboTableDirections = DisciplinesRelatedData.Tables["Directions"].Clone();
			DataRow row_directions_all = comboTableDirections.NewRow();
			row_directions_all["direction_id"] = 0;
			row_directions_all["direction_name"] = "Все";
			comboTableDirections.Rows.Add(row_directions_all);
			foreach (DataRow row in DisciplinesRelatedData.Tables["Directions"].Rows)
				comboTableDirections.ImportRow(row);

			comboBoxDisciplinesDirection.DataSource = comboTableDirections;
			comboBoxDisciplinesDirection.DisplayMember = "direction_name";
			comboBoxDisciplinesDirection.ValueMember = "direction_id";
			comboBoxDisciplinesDirection.SelectedIndex = 0;
		}
		void LoadTab(int i)
		{
			string tableName = tabControl.TabPages[i].Name.Remove(0, "tabPage".Length);
			DataGridView dataGridView = this.Controls.Find($"dataGridView{tableName}", true)[0] as DataGridView;
			dataGridView.DataSource = Select(queries[i].Fileds, queries[i].Tables, queries[i].Condition);
			if (i == 1) ConvertLearningDays();
		}
		DataTable Select(string fields, string tables, string condition = "")
		{
			DataTable table = new DataTable();
			string cmd = $"SELECT {fields} FROM {tables}";
			if (!string.IsNullOrWhiteSpace(condition)) cmd += $" WHERE {condition}";
			cmd += ";";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			return table;
		}
		void ConvertLearningDays()
		{
			for (int i = 0; i < dataGridViewGroups.RowCount; i++)
			{
				dataGridViewGroups.Rows[i].Cells["learning_days"].Value = new Week(Convert.ToByte(dataGridViewGroups.Rows[i].Cells["learning_days"].Value));
			}
		}
		Dictionary<string, int> LoadDataToComboBox(string fields, string tables)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary.Add("Все", 0);
			string cmd = $"SELECT {fields} FROM {tables}";
			SqlCommand command = new SqlCommand(cmd, connection);
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
			dataGridViewGroups.DataSource = Select("group_id,group_name,direction", "Groups,Directions", condition);
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
			dataGridViewStudents.DataSource = Select(queries[0].Fileds, queries[0].Tables, condition);
		}

		private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			string condition = queries[0].Condition;
			if (comboBoxStudentsGroup.SelectedItem.ToString() != "Все") condition += $" AND [group]={d_studentGroup[comboBoxStudentsGroup.SelectedItem.ToString()]}";
			dataGridViewStudents.DataSource = Select(queries[0].Fileds, queries[0].Tables, condition);
		}

		private void comboBoxDisciplinesDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxDisciplinesDirection.SelectedIndex != 0)
			{
				DataRow[] pjtRow = DisciplinesRelatedData.Tables["Directions"].Rows.Find(comboBoxDisciplinesDirection.SelectedValue).GetChildRows("DirectionsToDDRdirection");
				DataTable dataDisciplines = DisciplinesRelatedData.Tables["Disciplines"].Clone();
				foreach (DataRow dr in pjtRow)
				{
					Console.WriteLine($"{dr["discipline"]}\t{dr["direction"]}");
					dataDisciplines.ImportRow(DisciplinesRelatedData.Tables["Disciplines"].Rows.Find(dr["discipline"]));
				}
				dataGridViewDisciplines.DataSource = dataDisciplines;
			}
			else
				dataGridViewDisciplines.DataSource = DisciplinesRelatedData.Tables["Disciplines"];
		}
	}
}
