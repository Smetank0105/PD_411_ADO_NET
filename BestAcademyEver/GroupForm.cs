using MySqlLibrary;
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

namespace BestAcademyEver
{
	public partial class GroupForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int id {  get; set; }
		public GroupForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString, "Groups");
			mainForm.FillComboBox(comboBoxGroupForm_direction,mainForm.cache.GetDataTable("Directions"));
		}
		internal void LoadData()
		{
			DataTable table = MyConnector.Select(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString, $"SELECT * FROM Groups WHERE group_id={id}");
			textBoxGroupForm_groupName.Text = table.Rows[0]["group_name"].ToString();
			comboBoxGroupForm_direction.SelectedIndex = Convert.ToInt32(table.Rows[0]["direction"]);
			FromLearnngDays(Convert.ToInt32(table.Rows[0]["learning_days"]));
			dtpGroupForm_startTime.Value = DateTime.Parse(table.Rows[0]["start_time"].ToString());
		}

		internal string UploadData()
		{
			return $@"N'{textBoxGroupForm_groupName.Text}',
						{comboBoxGroupForm_direction.SelectedIndex},
						{ToLearningDays()},
						'{dtpGroupForm_startTime.Value.ToString("HH:mm")}'";
		}

		private void FromLearnngDays(int learning_days)
		{
			for (int i = 0; i < 7; i++)
			{
				if(learning_days%2 ==1)
					clbGroupForm_learningDays.SetItemChecked(i,true);
				learning_days = learning_days/2;
			}
		}

		private string ToLearningDays()
		{
			int digit = 0;
			for (int i = 0; i < 7; i++)
			{
				if (clbGroupForm_learningDays.GetItemChecked(i))
					digit += Convert.ToInt32(Math.Pow(2, i));
			}
			return digit.ToString();
		}
	}
}
