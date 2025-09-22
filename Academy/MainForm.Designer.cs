namespace Academy
{
	partial class MainForm
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.dataGridViewDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
			this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			this.tabPageGroups.SuspendLayout();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).BeginInit();
			this.tabPageDisciplines.SuspendLayout();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
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
			this.tabControl.Size = new System.Drawing.Size(800, 428);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 402);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 402);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.dataGridViewDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(792, 402);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDirections
			// 
			this.dataGridViewDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDirections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDirections.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewDirections.Name = "dataGridViewDirections";
			this.dataGridViewDirections.Size = new System.Drawing.Size(786, 396);
			this.dataGridViewDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Controls.Add(this.dataGridViewDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(792, 402);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.dataGridViewTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 402);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewStudents.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(786, 396);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewGroups.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.Size = new System.Drawing.Size(786, 396);
			this.dataGridViewGroups.TabIndex = 0;
			// 
			// dataGridViewDisciplines
			// 
			this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDisciplines.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDisciplines.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
			this.dataGridViewDisciplines.Size = new System.Drawing.Size(786, 396);
			this.dataGridViewDisciplines.TabIndex = 0;
			// 
			// dataGridViewTeachers
			// 
			this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTeachers.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewTeachers.Name = "dataGridViewTeachers";
			this.dataGridViewTeachers.Size = new System.Drawing.Size(792, 402);
			this.dataGridViewTeachers.TabIndex = 0;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Name = "MainForm";
			this.Text = "Academy PD_411";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirections)).EndInit();
			this.tabPageDisciplines.ResumeLayout(false);
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dataGridViewDirections;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
		private System.Windows.Forms.DataGridView dataGridViewDisciplines;
		private System.Windows.Forms.DataGridView dataGridViewTeachers;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}

