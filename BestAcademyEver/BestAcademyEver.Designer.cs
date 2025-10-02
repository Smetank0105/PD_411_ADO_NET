namespace BestAcademyEver
{
	partial class BestAcademyEver
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.buttonStudents_insert = new System.Windows.Forms.Button();
			this.comboBoxStudents_forGroups = new System.Windows.Forms.ComboBox();
			this.labelStudents_Group = new System.Windows.Forms.Label();
			this.comboBoxStudents_forDirections = new System.Windows.Forms.ComboBox();
			this.labelStudents_Direction = new System.Windows.Forms.Label();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.buttonGroups_insert = new System.Windows.Forms.Button();
			this.comboBoxGroups_forDirections = new System.Windows.Forms.ComboBox();
			this.labelGroups_Direction = new System.Windows.Forms.Label();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.buttonDirection_insert = new System.Windows.Forms.Button();
			this.dataGridViewDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.buttonDisciplines_insert = new System.Windows.Forms.Button();
			this.comboBoxDisciplines_forDirections = new System.Windows.Forms.ComboBox();
			this.labelDisciplines_Direction = new System.Windows.Forms.Label();
			this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.buttonTeachers_insert = new System.Windows.Forms.Button();
			this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).BeginInit();
			this.tabPageDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplines);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 450);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.buttonStudents_insert);
			this.tabPageStudents.Controls.Add(this.comboBoxStudents_forGroups);
			this.tabPageStudents.Controls.Add(this.labelStudents_Group);
			this.tabPageStudents.Controls.Add(this.comboBoxStudents_forDirections);
			this.tabPageStudents.Controls.Add(this.labelStudents_Direction);
			this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// buttonStudents_insert
			// 
			this.buttonStudents_insert.Location = new System.Drawing.Point(709, 3);
			this.buttonStudents_insert.Name = "buttonStudents_insert";
			this.buttonStudents_insert.Size = new System.Drawing.Size(75, 23);
			this.buttonStudents_insert.TabIndex = 5;
			this.buttonStudents_insert.Text = "Insert";
			this.buttonStudents_insert.UseVisualStyleBackColor = true;
			// 
			// comboBoxStudents_forGroups
			// 
			this.comboBoxStudents_forGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudents_forGroups.FormattingEnabled = true;
			this.comboBoxStudents_forGroups.Location = new System.Drawing.Point(446, 4);
			this.comboBoxStudents_forGroups.Name = "comboBoxStudents_forGroups";
			this.comboBoxStudents_forGroups.Size = new System.Drawing.Size(156, 21);
			this.comboBoxStudents_forGroups.TabIndex = 4;
			this.comboBoxStudents_forGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_forGroups_SelectedIndexChanged);
			// 
			// labelStudents_Group
			// 
			this.labelStudents_Group.AutoSize = true;
			this.labelStudents_Group.Location = new System.Drawing.Point(397, 8);
			this.labelStudents_Group.Name = "labelStudents_Group";
			this.labelStudents_Group.Size = new System.Drawing.Size(42, 13);
			this.labelStudents_Group.TabIndex = 3;
			this.labelStudents_Group.Text = "Группа";
			// 
			// comboBoxStudents_forDirections
			// 
			this.comboBoxStudents_forDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudents_forDirections.FormattingEnabled = true;
			this.comboBoxStudents_forDirections.Location = new System.Drawing.Point(87, 4);
			this.comboBoxStudents_forDirections.Name = "comboBoxStudents_forDirections";
			this.comboBoxStudents_forDirections.Size = new System.Drawing.Size(304, 21);
			this.comboBoxStudents_forDirections.TabIndex = 2;
			this.comboBoxStudents_forDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_forDirections_SelectedIndexChanged);
			// 
			// labelStudents_Direction
			// 
			this.labelStudents_Direction.AutoSize = true;
			this.labelStudents_Direction.Location = new System.Drawing.Point(6, 8);
			this.labelStudents_Direction.Name = "labelStudents_Direction";
			this.labelStudents_Direction.Size = new System.Drawing.Size(75, 13);
			this.labelStudents_Direction.TabIndex = 1;
			this.labelStudents_Direction.Text = "Направление";
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(6, 30);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(780, 370);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.buttonGroups_insert);
			this.tabPageGroups.Controls.Add(this.comboBoxGroups_forDirections);
			this.tabPageGroups.Controls.Add(this.labelGroups_Direction);
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// buttonGroups_insert
			// 
			this.buttonGroups_insert.Location = new System.Drawing.Point(709, 3);
			this.buttonGroups_insert.Name = "buttonGroups_insert";
			this.buttonGroups_insert.Size = new System.Drawing.Size(75, 23);
			this.buttonGroups_insert.TabIndex = 3;
			this.buttonGroups_insert.Text = "Insert";
			this.buttonGroups_insert.UseVisualStyleBackColor = true;
			// 
			// comboBoxGroups_forDirections
			// 
			this.comboBoxGroups_forDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroups_forDirections.FormattingEnabled = true;
			this.comboBoxGroups_forDirections.Location = new System.Drawing.Point(88, 4);
			this.comboBoxGroups_forDirections.Name = "comboBoxGroups_forDirections";
			this.comboBoxGroups_forDirections.Size = new System.Drawing.Size(304, 21);
			this.comboBoxGroups_forDirections.TabIndex = 2;
			this.comboBoxGroups_forDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_forDirections_SelectedIndexChanged);
			// 
			// labelGroups_Direction
			// 
			this.labelGroups_Direction.AutoSize = true;
			this.labelGroups_Direction.Location = new System.Drawing.Point(6, 8);
			this.labelGroups_Direction.Name = "labelGroups_Direction";
			this.labelGroups_Direction.Size = new System.Drawing.Size(75, 13);
			this.labelGroups_Direction.TabIndex = 1;
			this.labelGroups_Direction.Text = "Направление";
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Location = new System.Drawing.Point(6, 30);
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.Size = new System.Drawing.Size(780, 370);
			this.dataGridViewGroups.TabIndex = 0;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.buttonDirection_insert);
			this.tabPageDirections.Controls.Add(this.dataGridViewDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(792, 424);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// buttonDirection_insert
			// 
			this.buttonDirection_insert.Location = new System.Drawing.Point(709, 3);
			this.buttonDirection_insert.Name = "buttonDirection_insert";
			this.buttonDirection_insert.Size = new System.Drawing.Size(75, 23);
			this.buttonDirection_insert.TabIndex = 1;
			this.buttonDirection_insert.Text = "Insert";
			this.buttonDirection_insert.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDirections
			// 
			this.dataGridViewDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDirections.Location = new System.Drawing.Point(6, 30);
			this.dataGridViewDirections.Name = "dataGridViewDirections";
			this.dataGridViewDirections.Size = new System.Drawing.Size(780, 370);
			this.dataGridViewDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Controls.Add(this.buttonDisciplines_insert);
			this.tabPageDisciplines.Controls.Add(this.comboBoxDisciplines_forDirections);
			this.tabPageDisciplines.Controls.Add(this.labelDisciplines_Direction);
			this.tabPageDisciplines.Controls.Add(this.dataGridViewDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(792, 424);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// buttonDisciplines_insert
			// 
			this.buttonDisciplines_insert.Location = new System.Drawing.Point(709, 3);
			this.buttonDisciplines_insert.Name = "buttonDisciplines_insert";
			this.buttonDisciplines_insert.Size = new System.Drawing.Size(75, 23);
			this.buttonDisciplines_insert.TabIndex = 3;
			this.buttonDisciplines_insert.Text = "Insert";
			this.buttonDisciplines_insert.UseVisualStyleBackColor = true;
			// 
			// comboBoxDisciplines_forDirections
			// 
			this.comboBoxDisciplines_forDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDisciplines_forDirections.FormattingEnabled = true;
			this.comboBoxDisciplines_forDirections.Location = new System.Drawing.Point(87, 4);
			this.comboBoxDisciplines_forDirections.Name = "comboBoxDisciplines_forDirections";
			this.comboBoxDisciplines_forDirections.Size = new System.Drawing.Size(304, 21);
			this.comboBoxDisciplines_forDirections.TabIndex = 2;
			this.comboBoxDisciplines_forDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplines_forDirections_SelectedIndexChanged);
			// 
			// labelDisciplines_Direction
			// 
			this.labelDisciplines_Direction.AutoSize = true;
			this.labelDisciplines_Direction.Location = new System.Drawing.Point(6, 8);
			this.labelDisciplines_Direction.Name = "labelDisciplines_Direction";
			this.labelDisciplines_Direction.Size = new System.Drawing.Size(75, 13);
			this.labelDisciplines_Direction.TabIndex = 1;
			this.labelDisciplines_Direction.Text = "Направление";
			// 
			// dataGridViewDisciplines
			// 
			this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDisciplines.Location = new System.Drawing.Point(6, 30);
			this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
			this.dataGridViewDisciplines.Size = new System.Drawing.Size(780, 370);
			this.dataGridViewDisciplines.TabIndex = 0;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.buttonTeachers_insert);
			this.tabPageTeachers.Controls.Add(this.dataGridViewTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 424);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// buttonTeachers_insert
			// 
			this.buttonTeachers_insert.Location = new System.Drawing.Point(709, 3);
			this.buttonTeachers_insert.Name = "buttonTeachers_insert";
			this.buttonTeachers_insert.Size = new System.Drawing.Size(75, 23);
			this.buttonTeachers_insert.TabIndex = 1;
			this.buttonTeachers_insert.Text = "insert";
			this.buttonTeachers_insert.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTeachers
			// 
			this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTeachers.Location = new System.Drawing.Point(6, 30);
			this.dataGridViewTeachers.Name = "dataGridViewTeachers";
			this.dataGridViewTeachers.Size = new System.Drawing.Size(780, 370);
			this.dataGridViewTeachers.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel";
			// 
			// BestAcademyEver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl);
			this.Name = "BestAcademyEver";
			this.Text = "BestAcademyEver";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			this.tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).EndInit();
			this.tabPageDisciplines.ResumeLayout(false);
			this.tabPageDisciplines.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.DataGridView dataGridViewDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dataGridViewDisciplines;
		private System.Windows.Forms.DataGridView dataGridViewTeachers;
		private System.Windows.Forms.Label labelStudents_Direction;
		private System.Windows.Forms.Button buttonStudents_insert;
		private System.Windows.Forms.ComboBox comboBoxStudents_forGroups;
		private System.Windows.Forms.Label labelStudents_Group;
		private System.Windows.Forms.ComboBox comboBoxStudents_forDirections;
		private System.Windows.Forms.Label labelGroups_Direction;
		private System.Windows.Forms.Button buttonGroups_insert;
		private System.Windows.Forms.ComboBox comboBoxGroups_forDirections;
		private System.Windows.Forms.Button buttonDirection_insert;
		private System.Windows.Forms.Button buttonDisciplines_insert;
		private System.Windows.Forms.ComboBox comboBoxDisciplines_forDirections;
		private System.Windows.Forms.Label labelDisciplines_Direction;
		private System.Windows.Forms.Button buttonTeachers_insert;
	}
}

