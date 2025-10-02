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
	public partial class DisciplineForm : Form
	{
		private MainForm mainForm;
		internal MyConnector connector;
		internal int id {  get; set; }
		public DisciplineForm(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
			connector = new MyConnector(ConfigurationManager.ConnectionStrings["PD_321"].ConnectionString, "Disciplines");
		}
		internal void LoadData()
		{
			textBoxDisciplineForm_disciplineName.Text = mainForm.cache.GetDataTable("Disciplines").Rows.Find(id)["Дисциплина"].ToString();
			textBoxDisciplineForm_numberOfLessons.Text = mainForm.cache.GetDataTable("Disciplines").Rows.Find(id)["Кол-во занятий"].ToString();
		}
		internal string UploadData()
		{
			return $"N'{textBoxDisciplineForm_disciplineName.Text}',{Convert.ToInt32(textBoxDisciplineForm_numberOfLessons.Text)}";
		}
	}
}
