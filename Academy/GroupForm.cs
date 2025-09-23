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
	public partial class GroupForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector_to_Groups;
		internal int group_id { get; set; }
		
		public GroupForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector_to_Groups = new MyConnector(this.mainForm.connectionString, "Groups");
			comboBoxGroups_direction.Items.AddRange(this.mainForm.d_groupDirection.Keys.ToArray());
		}
		public void LoadGroupData()
		{
			DataTable table = MyConnector.Select(this.mainForm.connectionString, $"SELECT * FROM Groups WHERE group_id={this.group_id}");
			textBoxGroups_groupName.Text = table.Rows[0]["group_name"].ToString();
			comboBoxGroups_direction.SelectedIndex = Convert.ToInt32(table.Rows[0]["direction"]);
			CheckedFromLearningDays(Convert.ToInt32(table.Rows[0]["learning_days"]));
			dateTimePickerGroups_startTime.Value = DateTime.Parse(table.Rows[0]["start_time"].ToString());
		}
		public string UploadGroupData()
		{
			string cmd = $"N'{textBoxGroups_groupName.Text.Trim()}',{comboBoxGroups_direction.SelectedIndex},{CheckedToLearningDays().Trim()},'{dateTimePickerGroups_startTime.Value.ToString("HH:mm")}'";
			return cmd;
		}
		private void CheckedFromLearningDays(int learning_days)
		{
			for (int i = 0; i < 7; i++)
			{
				if(learning_days%2 == 1)
					checkedListBoxGroups_learningDays.SetItemChecked(i, true);
				learning_days = learning_days/2;
			}
		}
		private string CheckedToLearningDays()
		{
			int digit = 0;
			for(int i = 0; i < 7; i++)
			{
				if (checkedListBoxGroups_learningDays.GetItemChecked(i))
					digit += Convert.ToInt32(Math.Pow(2, i));
			}
			return digit.ToString();
		}
	}
}
