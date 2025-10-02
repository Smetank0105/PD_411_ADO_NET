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
	public partial class DirectionForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int id {  get; set; }
		public DirectionForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString,"Directions");
		}
		internal void LoadData()
		{
			textBoxDirectionForm_directionName.Text = mainForm.cache.GetDataTable("Directions").Rows.Find(id)[1].ToString();
		}
		internal string UploadData()
		{
			return $"N'{textBoxDirectionForm_directionName.Text}'";
		}
	}
}
