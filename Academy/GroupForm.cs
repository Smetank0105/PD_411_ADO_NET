using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlLibrary;

namespace Academy
{
	public partial class GroupForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int group_id {  get; set; }
		public GroupForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(this.mainForm.connectionString, "Groups");
			comboBoxGroup_direction.Items.AddRange(this.mainForm.LoadDataToComboBox("*", "Directions").Keys.ToArray());
		}
		private void CheckedFromLearningDays(int learning_days)
		{
			for(int i = 0; i < 7; i++)
			{
				if(learning_days%2 == 1)
					checkedListBoxGroup_learningDays.SetItemChecked(i, true);
				learning_days = learning_days/2;
			}
		}
		private string CheckedToLearningDays()
		{
			int digit = 0;
			for (int i = 0; i < 7; i++)
			{
				if (checkedListBoxGroup_learningDays.GetItemChecked(i))
					digit += Convert.ToInt32(Math.Pow(2, i));
			}
			return digit.ToString();
		}
		internal void LoadGroupData()
		{
			DataTable table = MyConnector.Select(this.mainForm.connectionString, $"SELECT * FROM Groups WHERE group_id={this.group_id}");
			textBoxGroup_groupName.Text = table.Rows[0]["group_name"].ToString();
			comboBoxGroup_direction.SelectedIndex = Convert.ToInt32(table.Rows[0]["direction"]);
			CheckedFromLearningDays(Convert.ToInt32(table.Rows[0]["learning_days"]));
			dateTimePickerGroup_startTime.Value = DateTime.Parse(table.Rows[0]["start_time"].ToString());
		}
		internal string UploadGroupData()
		{
			string cmd = $"N'{textBoxGroup_groupName .Text .Trim()}',{comboBoxGroup_direction.SelectedIndex},{CheckedToLearningDays().Trim()},'{dateTimePickerGroup_startTime.Value.ToString("HH:mm")}'";
			return cmd;
		}
	}
}
