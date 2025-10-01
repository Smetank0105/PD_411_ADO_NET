using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySqlLibrary;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BestAcademyEver
{
	public partial class BestAcademyEver : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString;
		MyConnector connector;
		MyCache cache;

		Query[] queries = new Query[]
		{
			new Query
			(
			"stud_id,FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name) AS N'Студент',birth_date AS N'Дата рождения',group_name AS N'Группа',direction_name AS N'Направление'",
			"Students,Groups,Directions",
			"[group]=group_id AND direction=direction_id"
			),
			new Query
			(
				"group_id,group_name AS N'Группа',direction_name AS N'Направление',learning_days AS N'Учебные дни',start_time AS N'Начало занятий'",
				"Groups,Directions",
				"direction=direction_id"
			),
			new Query("direction_id,direction_name AS N'Направление'","Directions"),
			new Query("discipline_id,discipline_name AS N'Дисциплина',number_of_lessons AS N'Кол-во занятий'","Disciplines"),
			new Query
			(
				"teacher_id,FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name) AS N'Преподаватель',birth_date AS N'Дата рождения',work_since AS N'Опыт работы',rate AS N'Рейтинг'",
				"Teachers"
			)
		};
		public BestAcademyEver()
		{
			InitializeComponent();
			AllocConsole();
			cache = new MyCache(connectionString);
			FillDataSet();
			FillAllComboBox();
			dataGridViewDirections.DataSource = cache.GetDataTable(queries[2].Tables);
		}
		//FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS////FUNCTIONS//
		private void FillDataSet()
		{
			cache.FillDataSet($"SELECT {queries[2].Fileds} FROM {queries[2].Tables}", queries[2].Tables);
			cache.AddPrimaryKey(queries[2].Tables, new DataColumn[] { cache.GetDataTable(queries[2].Tables).Columns["direction_id"] });
			cache.FillDataSet($"SELECT {queries[3].Fileds} FROM {queries[3].Tables}", queries[3].Tables);
			cache.AddPrimaryKey(queries[3].Tables, new DataColumn[] { cache.GetDataTable(queries[3].Tables).Columns["discipline_id"] });
			cache.FillDataSet("SELECT * FROM DisciplinesDirectionsRelation", "DDR");
			cache.AddPrimaryKey
				(
				"DDR",
				new DataColumn[]
				{
					cache.GetDataTable("DDR").Columns["direction"],
					cache.GetDataTable("DDR").Columns["discipline"]
				}
				);
			cache.AddRelation("DirectionsToDDR", "Directions", "direction_id", "DDR", "direction");
			cache.AddRelation("DisciplinesToDDR", "Disciplines", "discipline_id", "DDR", "discipline");
		}
		private void FillAllComboBox()
		{
			FillComboBox(comboBoxStudents_forDirections, cache.GetDataTable(queries[2].Tables));
			FillComboBox(comboBoxGroups_forDirections, cache.GetDataTable(queries[2].Tables));
			FillComboBox(comboBoxDisciplines_forDirections, cache.GetDataTable(queries[2].Tables));
		}
		private void FillComboBox(ComboBox comboBox, DataTable dataTable)
		{
			comboBox.DataSource = GetComboTable(dataTable);
			comboBox.DisplayMember = "Name";
			comboBox.ValueMember = "Id";
			comboBox.SelectedIndex = 0;
		}
		private DataTable GetComboTable(DataTable dataTable)
		{
			DataTable table = new DataTable();
			table.Columns.Add("Id");
			table.Columns.Add("Name");
			DataRow newRow = table.NewRow();
			newRow[0] = 0;
			newRow[1] = "Все";
			table.Rows.Add(newRow);
			foreach (DataRow row in dataTable.Rows)
			{
				newRow = table.NewRow();
				newRow[0] = row[0];
				newRow[1] = row[1];
				table.Rows.Add(newRow);
			}
			return table;
		}
		//CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE////CONSOLE//
		[DllImport("Kernel32.dll")]
		static extern void AllocConsole();
		//EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS////EVENTS//
		private void comboBoxStudents_forDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cmd = "SELECT group_id, group_name FROM Groups";
			if ((sender as ComboBox).SelectedIndex != 0)
				cmd += $" WHERE direction = {(sender as ComboBox).SelectedValue}";
			DataTable dataTable = MyConnector.Select(connectionString, cmd);
			FillComboBox(comboBoxStudents_forGroups, dataTable);
		}
		private void comboBoxStudents_forGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cmd = $"SELECT {queries[0].Fileds} FROM {queries[0].Tables} WHERE {queries[0].Condition}";
			if ((sender as ComboBox).SelectedIndex != 0)
				cmd += $" AND [group] = {(sender as ComboBox).SelectedValue}";
			else if (comboBoxStudents_forDirections.SelectedIndex != 0)
				cmd += $" AND [group] IN (SELECT group_id FROM Groups WHERE direction = {comboBoxStudents_forDirections.SelectedValue})";
			dataGridViewStudents.DataSource = MyConnector.Select(connectionString, cmd);
		}
		private void comboBoxGroups_forDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cmd = $"SELECT {queries[1].Fileds} FROM {queries[1].Tables} WHERE {queries[1].Condition}";
			if ((sender as ComboBox).SelectedIndex != 0)
				cmd += $" AND direction = {(sender as ComboBox).SelectedValue}";
			dataGridViewGroups.DataSource = MyConnector.Select(connectionString, cmd);
		}

		private void comboBoxDisciplines_forDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).SelectedIndex != 0)
			{
				DataRow rowDirection = cache.GetDataTable("Directions").Rows.Find((sender as ComboBox).SelectedValue);
				if (rowDirection != null)
				{
					DataRow[] rows = rowDirection.GetChildRows("DirectionsToDDR");
					DataTable table = cache.GetDataTable("Disciplines").Clone();
					foreach (DataRow row in rows)
					{
						table.ImportRow(cache.GetDataTable("Disciplines").Rows.Find(row["discipline"]));
					}
					dataGridViewDisciplines.DataSource = table;
				}
				else
					dataGridViewDisciplines.DataSource = null;
			}
			else
				dataGridViewDisciplines.DataSource = cache.GetDataTable("Disciplines");
		}
	}
}
