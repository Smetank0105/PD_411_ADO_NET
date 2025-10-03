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
using System.Configuration;
using System.Runtime.InteropServices;

namespace DataSet
{
	public partial class MainForm : Form
	{
		string connectionString = "";
		SqlConnection connection = null;
		System.Data.DataSet GroupsRelatedData = null;
		System.Data.DataSet DisciplinesDirectionsRelation = null;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString;
			connection = new SqlConnection(connectionString);

			InitGroupsRelatedData();
			InitDisciplinesDirectionsRelation();
		}
		void InitGroupsRelatedData()
		{
			//1) Создаем DataSet
			GroupsRelatedData = new System.Data.DataSet(nameof(GroupsRelatedData));

			//2) Добавляем таблицы в DataSet
			const string dsTable_Directions = "Directions";
			const string dstDirections_col_direction_id = "direction_id";
			const string dstDirections_col_direction_name = "direction_name";
			GroupsRelatedData.Tables.Add(dsTable_Directions);

			//3) Добавляем поля в таблицу
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_id);
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_name);

			//4) Выбираем первичный ключ
			GroupsRelatedData.Tables[dsTable_Directions].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id] };

			const string dsTable_Groups = "Groups";
			const string dstGroups_col_group_id = "group_id";
			const string dstGroups_col_group_name = "group_name";
			const string dstGroups_col_direction = "direction";
			const string dstGroups_col_learning_days = "learning_days";
			const string dstGroups_col_start_time = "start_time";
			GroupsRelatedData.Tables.Add(dsTable_Groups);

			GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_group_id);
			GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_group_name);
			GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_direction);
			GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_learning_days);
			GroupsRelatedData.Tables[dsTable_Groups].Columns.Add(dstGroups_col_start_time);

			GroupsRelatedData.Tables[dsTable_Groups].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_id] };

			//5) Строим связи между таблицами
			string dsRelation_GroupsDirections = "GroupsDirections";
			GroupsRelatedData.Relations.Add
				(
				dsRelation_GroupsDirections,
				GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id],
				GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_direction]
				);

			//6) Загружаем данные в таблицу
			string directions_cmd = "SELECT * FROM Directions";
			string groups_cmd = "SELECT * FROM Groups";

			SqlDataAdapter directionsAdapter = new SqlDataAdapter(directions_cmd, connection);
			SqlDataAdapter groupsAdapter = new SqlDataAdapter(groups_cmd, connection);

			directionsAdapter.Fill(GroupsRelatedData.Tables[dsTable_Directions]);
			groupsAdapter.Fill(GroupsRelatedData.Tables[dsTable_Groups]);

			AllocConsole();
			foreach (DataRow row in GroupsRelatedData.Tables[dsTable_Directions].Rows)
				Console.WriteLine($"{row[dstDirections_col_direction_id]}\t{row[dstDirections_col_direction_name]}");

			DataRow[] RPO = GroupsRelatedData.Tables[dsTable_Directions].Rows[0].GetChildRows(dsRelation_GroupsDirections);
			for (int i = 0; i < RPO.Length; i++)
			{
				for (int j = 0; j < RPO[i].ItemArray.Length; j++)
					Console.Write($"{RPO[i].ItemArray[j]}\t");
				Console.WriteLine();
			}

			comboBoxStudentsGroup.DataSource = GroupsRelatedData.Tables[dsTable_Groups];
			comboBoxStudentsGroup.DisplayMember = GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_name].ToString();
			comboBoxStudentsGroup.ValueMember = GroupsRelatedData.Tables[dsTable_Groups].Columns[dstGroups_col_group_id].ToString();

			comboBoxStudentsDirection.DataSource = GroupsRelatedData.Tables[dsTable_Directions];
			comboBoxStudentsDirection.DisplayMember = GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_name].ToString();
			comboBoxStudentsDirection.ValueMember = GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id].ToString();

			comboBoxStudentsGroup.SelectedIndexChanged += new EventHandler(GetKeyValue);
			comboBoxStudentsDirection.SelectedIndexChanged += new EventHandler(GetKeyValue);

		}
		void InitDisciplinesDirectionsRelation()
		{
			DisciplinesDirectionsRelation = new System.Data.DataSet(nameof(DisciplinesDirectionsRelation));
			string dsTable_Disciplines = "Disciplines";
			string dst_Disciplines_discipline_id = "discipline_id";
			string dst_Disciplines_discipline_name = "discipline_name";
			string dst_Disciplines_number_of_lessons = "number_of_lessons";
			DisciplinesDirectionsRelation.Tables.Add(dsTable_Disciplines);
			DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].Columns.Add(dst_Disciplines_discipline_id);
			DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].Columns.Add(dst_Disciplines_discipline_name);
			DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].Columns.Add(dst_Disciplines_number_of_lessons);
			DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].PrimaryKey = new DataColumn[] { DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].Columns[dst_Disciplines_discipline_id] };

			string dsTable_Directions = "Directions";
			string dstDirections_direction_id = "direction_id";
			string dstDirections_direction_name = "direction_name";
			DisciplinesDirectionsRelation.Tables.Add(dsTable_Directions);
			DisciplinesDirectionsRelation.Tables[dsTable_Directions].Columns.Add(dstDirections_direction_id);
			DisciplinesDirectionsRelation.Tables[dsTable_Directions].Columns.Add(dstDirections_direction_name);
			DisciplinesDirectionsRelation.Tables[dsTable_Directions].PrimaryKey = new DataColumn[] { DisciplinesDirectionsRelation.Tables[dsTable_Directions].Columns[dstDirections_direction_id] };

			string dsTable_DDR = "DisciplinesDirectionsRelation";
			string dstDDR_direction = "direction";
			string dstDDR_discipline = "discipline";
			DisciplinesDirectionsRelation.Tables.Add(dsTable_DDR);
			DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns.Add(dstDDR_direction);
			DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns.Add(dstDDR_discipline);
			DisciplinesDirectionsRelation.Tables[dsTable_DDR].PrimaryKey = new DataColumn[]
				{
					DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns[dstDDR_direction],
					DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns[dstDDR_discipline]
				};

			string dsrDiscipline = "Discipline";
			string dsrDirection = "Direction";

			DisciplinesDirectionsRelation.Relations.Add
				(
				dsrDiscipline, DisciplinesDirectionsRelation.Tables[dsTable_Disciplines].Columns[dst_Disciplines_discipline_id],
				DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns[dstDDR_discipline]
				);
			DisciplinesDirectionsRelation.Relations.Add
				(
				dsrDirection, DisciplinesDirectionsRelation.Tables[dsTable_Directions].Columns[dstDirections_direction_id],
				DisciplinesDirectionsRelation.Tables[dsTable_DDR].Columns[dstDDR_direction]
				);

			SqlDataAdapter directionsAdapter = new SqlDataAdapter($"SELECT * FROM {dsTable_Directions}", connection);
			SqlDataAdapter disciplinesAdapter = new SqlDataAdapter($"SELECT * FROM {dsTable_Disciplines}", connection);
			SqlDataAdapter ddrAdapter = new SqlDataAdapter($"SELECT * FROM {dsTable_DDR}", connection);

			directionsAdapter.Fill(DisciplinesDirectionsRelation.Tables[dsTable_Directions]);
			disciplinesAdapter.Fill(DisciplinesDirectionsRelation.Tables[dsTable_Disciplines]);
			ddrAdapter.Fill(DisciplinesDirectionsRelation.Tables[dsTable_DDR]);
			/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			dataGridViewDisciplines.DataSource = DisciplinesDirectionsRelation.Tables[dsTable_Disciplines];

			comboBoxDisciplinesForDirection.DataSource = DisciplinesDirectionsRelation.Tables[dsTable_Directions];
			comboBoxDisciplinesForDirection.DisplayMember = dstDirections_direction_name;
			comboBoxDisciplinesForDirection.ValueMember = dstDirections_direction_id;
		}
		void GetKeyValue(object sender, EventArgs e)
		{
			Console.WriteLine($"{(sender as ComboBox).Name}\t{(sender as ComboBox).SelectedValue}");
		}
		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();

		private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				comboBoxStudentsGroup.Enabled = true;
				comboBoxStudentsGroup.DataSource = GroupsRelatedData.Tables["Groups"].Select($"direction = {comboBoxStudentsDirection.SelectedValue}").CopyToDataTable();
			}
			catch (Exception ex)
			{
				comboBoxStudentsGroup.Enabled = false;
			}
		}

		private void comboBoxDisciplinesForDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			//DataRow[] ddr = DisciplinesDirectionsRelation.Tables["DisciplinesDirectionsRelation"].Select($"direction={comboBoxDisciplinesForDirection.SelectedValue}");
			//DataTable dtDisciplinesForDirection = DisciplinesDirectionsRelation.Tables["Disciplines"].Clone();
			//foreach (DataRow row in ddr)
			//{
			//	DataRow discipline = DisciplinesDirectionsRelation.Tables["Disciplines"].Rows.Find(row["discipline"]);
			//	dtDisciplinesForDirection.ImportRow(discipline);
			//}
			//dataGridViewDisciplines.DataSource = dtDisciplinesForDirection;

			DataRow[] ddr = DisciplinesDirectionsRelation.Tables["DisciplinesDirectionsRelation"]
				.Select($"direction={comboBoxDisciplinesForDirection.SelectedValue}");
			DataTable dtDisciplines = DisciplinesDirectionsRelation.Tables["Disciplines"].Clone();

			object[] disciplines_ids = ddr.Select(row => row["discipline"]).Distinct().ToArray();
			string filter = $"discipline_id IN ({string.Join(",", disciplines_ids)})";
			dataGridViewDisciplines.DataSource = DisciplinesDirectionsRelation.Tables["Disciplines"].Select(filter).CopyToDataTable();
		}
	}
}
