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
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString;
			connection = new SqlConnection(connectionString);

			//1) Создаем DataSet
			GroupsRelatedData = new System.Data.DataSet(nameof(GroupsRelatedData));

			//2) Добавляем таблицы в DataSet
			const string dsTable_Directions = "Directions";
			GroupsRelatedData.Tables.Add(dsTable_Directions);

			//3) Добавляем поля в таблицу
			const string dstDirections_col_direction_id = "direction_id";
			const string dstDirections_col_direction_name = "direction_name";
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_id);
			GroupsRelatedData.Tables[dsTable_Directions].Columns.Add(dstDirections_col_direction_name);

			//4) Выбираем первичный ключ
			GroupsRelatedData.Tables[dsTable_Directions].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables[dsTable_Directions].Columns[dstDirections_col_direction_id] };

			const string dsTable_Groups = "Groups";
			GroupsRelatedData.Tables.Add(dsTable_Groups);

			const string dstGroups_col_group_id = "group_id";
			const string dstGroups_col_group_name = "group_name";
			const string dstGroups_col_direction = "direction";
			const string dstGroups_col_learning_days = "learning_days";
			const string dstGroups_col_start_time = "start_time";
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

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			DataTable comboTableDirection = GroupsRelatedData.Tables[dsTable_Directions].Clone();
			DataRow row_direction_all = comboTableDirection.NewRow();
			row_direction_all[dstDirections_col_direction_id] = 0;
			row_direction_all[dstDirections_col_direction_name] = "Все";
			comboTableDirection.Rows.Add(row_direction_all);
			foreach (DataRow dr in GroupsRelatedData.Tables[dsTable_Directions].Rows)
				comboTableDirection.ImportRow(dr);

			comboBoxDirection.DataSource = comboTableDirection;
			comboBoxDirection.DisplayMember = dstDirections_col_direction_name;
			comboBoxDirection.ValueMember = dstDirections_col_direction_id;
			comboBoxDirection.SelectedIndex = 0;
		}
		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();

		private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable comboTableGroup = GroupsRelatedData.Tables["Groups"].Clone();
			DataView comboTableGroupView = new DataView(comboTableGroup);
			if (comboBoxDirection.SelectedIndex == 0)
				comboTableGroupView.RowFilter = "";
			else
				comboTableGroupView.RowFilter = $"direction = {comboBoxDirection.SelectedValue}";

			DataRow row_group_all = comboTableGroup.NewRow();
			row_group_all["group_id"] = 0;
			row_group_all["direction"] = comboBoxDirection.SelectedValue;
			row_group_all["group_name"] = "Все";
			comboTableGroup.Rows.Add(row_group_all);
			foreach(DataRow dr in GroupsRelatedData.Tables["Groups"].Rows)
				comboTableGroup.ImportRow(dr);

			comboBoxGroup.DataSource = comboTableGroupView;
			comboBoxGroup.DisplayMember = "group_name";
			comboBoxGroup.ValueMember = "group_id";
			comboBoxGroup.SelectedIndex = 0;
		}

		private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataView groupView = new DataView(GroupsRelatedData.Tables["Groups"]);
			if (comboBoxGroup.SelectedIndex == 0 && comboBoxDirection.SelectedIndex == 0)
				groupView.RowFilter = "";
			else if (comboBoxGroup.SelectedIndex == 0)
				groupView.RowFilter = $"direction = {comboBoxDirection.SelectedValue}";
			else
				groupView.RowFilter = $"group_id = {comboBoxGroup.SelectedValue}";
			dataGridViewGroups.DataSource = groupView;
		}
	}
}
