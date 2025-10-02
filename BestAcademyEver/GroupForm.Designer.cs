namespace BestAcademyEver
{
	partial class GroupForm
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
			this.labelGroupForm_groupName = new System.Windows.Forms.Label();
			this.labelGroupForm_direction = new System.Windows.Forms.Label();
			this.labelGroupForm_learning_days = new System.Windows.Forms.Label();
			this.labelGroupForm_startTime = new System.Windows.Forms.Label();
			this.buttonGroupForm_ok = new System.Windows.Forms.Button();
			this.buttonGroupForm_cancel = new System.Windows.Forms.Button();
			this.textBoxGroupForm_groupName = new System.Windows.Forms.TextBox();
			this.clbGroupForm_learningDays = new System.Windows.Forms.CheckedListBox();
			this.dtpGroupForm_startTime = new System.Windows.Forms.DateTimePicker();
			this.comboBoxGroupForm_direction = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelGroupForm_groupName
			// 
			this.labelGroupForm_groupName.AutoSize = true;
			this.labelGroupForm_groupName.Location = new System.Drawing.Point(13, 17);
			this.labelGroupForm_groupName.Name = "labelGroupForm_groupName";
			this.labelGroupForm_groupName.Size = new System.Drawing.Size(42, 13);
			this.labelGroupForm_groupName.TabIndex = 0;
			this.labelGroupForm_groupName.Text = "Группа";
			// 
			// labelGroupForm_direction
			// 
			this.labelGroupForm_direction.AutoSize = true;
			this.labelGroupForm_direction.Location = new System.Drawing.Point(13, 59);
			this.labelGroupForm_direction.Name = "labelGroupForm_direction";
			this.labelGroupForm_direction.Size = new System.Drawing.Size(75, 13);
			this.labelGroupForm_direction.TabIndex = 1;
			this.labelGroupForm_direction.Text = "Направление";
			// 
			// labelGroupForm_learning_days
			// 
			this.labelGroupForm_learning_days.AutoSize = true;
			this.labelGroupForm_learning_days.Location = new System.Drawing.Point(13, 141);
			this.labelGroupForm_learning_days.Name = "labelGroupForm_learning_days";
			this.labelGroupForm_learning_days.Size = new System.Drawing.Size(73, 13);
			this.labelGroupForm_learning_days.TabIndex = 2;
			this.labelGroupForm_learning_days.Text = "Учебные дни";
			// 
			// labelGroupForm_startTime
			// 
			this.labelGroupForm_startTime.AutoSize = true;
			this.labelGroupForm_startTime.Location = new System.Drawing.Point(13, 225);
			this.labelGroupForm_startTime.Name = "labelGroupForm_startTime";
			this.labelGroupForm_startTime.Size = new System.Drawing.Size(122, 13);
			this.labelGroupForm_startTime.TabIndex = 3;
			this.labelGroupForm_startTime.Text = "Время начала занятий";
			// 
			// buttonGroupForm_ok
			// 
			this.buttonGroupForm_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonGroupForm_ok.Location = new System.Drawing.Point(99, 276);
			this.buttonGroupForm_ok.Name = "buttonGroupForm_ok";
			this.buttonGroupForm_ok.Size = new System.Drawing.Size(75, 27);
			this.buttonGroupForm_ok.TabIndex = 4;
			this.buttonGroupForm_ok.Text = " Ok";
			this.buttonGroupForm_ok.UseVisualStyleBackColor = true;
			// 
			// buttonGroupForm_cancel
			// 
			this.buttonGroupForm_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonGroupForm_cancel.Location = new System.Drawing.Point(193, 276);
			this.buttonGroupForm_cancel.Name = "buttonGroupForm_cancel";
			this.buttonGroupForm_cancel.Size = new System.Drawing.Size(75, 27);
			this.buttonGroupForm_cancel.TabIndex = 5;
			this.buttonGroupForm_cancel.Text = "Cancel";
			this.buttonGroupForm_cancel.UseVisualStyleBackColor = true;
			// 
			// textBoxGroupForm_groupName
			// 
			this.textBoxGroupForm_groupName.Location = new System.Drawing.Point(115, 13);
			this.textBoxGroupForm_groupName.Name = "textBoxGroupForm_groupName";
			this.textBoxGroupForm_groupName.Size = new System.Drawing.Size(153, 20);
			this.textBoxGroupForm_groupName.TabIndex = 6;
			// 
			// clbGroupForm_learningDays
			// 
			this.clbGroupForm_learningDays.FormattingEnabled = true;
			this.clbGroupForm_learningDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
			this.clbGroupForm_learningDays.Location = new System.Drawing.Point(115, 93);
			this.clbGroupForm_learningDays.Name = "clbGroupForm_learningDays";
			this.clbGroupForm_learningDays.Size = new System.Drawing.Size(153, 109);
			this.clbGroupForm_learningDays.TabIndex = 8;
			// 
			// dtpGroupForm_startTime
			// 
			this.dtpGroupForm_startTime.CustomFormat = "  HH:mm";
			this.dtpGroupForm_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpGroupForm_startTime.Location = new System.Drawing.Point(168, 221);
			this.dtpGroupForm_startTime.Name = "dtpGroupForm_startTime";
			this.dtpGroupForm_startTime.ShowUpDown = true;
			this.dtpGroupForm_startTime.Size = new System.Drawing.Size(100, 20);
			this.dtpGroupForm_startTime.TabIndex = 9;
			// 
			// comboBoxGroupForm_direction
			// 
			this.comboBoxGroupForm_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroupForm_direction.FormattingEnabled = true;
			this.comboBoxGroupForm_direction.Location = new System.Drawing.Point(115, 55);
			this.comboBoxGroupForm_direction.Name = "comboBoxGroupForm_direction";
			this.comboBoxGroupForm_direction.Size = new System.Drawing.Size(153, 21);
			this.comboBoxGroupForm_direction.TabIndex = 10;
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 320);
			this.Controls.Add(this.comboBoxGroupForm_direction);
			this.Controls.Add(this.dtpGroupForm_startTime);
			this.Controls.Add(this.clbGroupForm_learningDays);
			this.Controls.Add(this.textBoxGroupForm_groupName);
			this.Controls.Add(this.buttonGroupForm_cancel);
			this.Controls.Add(this.buttonGroupForm_ok);
			this.Controls.Add(this.labelGroupForm_startTime);
			this.Controls.Add(this.labelGroupForm_learning_days);
			this.Controls.Add(this.labelGroupForm_direction);
			this.Controls.Add(this.labelGroupForm_groupName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "GroupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroupForm_groupName;
		private System.Windows.Forms.Label labelGroupForm_direction;
		private System.Windows.Forms.Label labelGroupForm_learning_days;
		private System.Windows.Forms.Label labelGroupForm_startTime;
		private System.Windows.Forms.Button buttonGroupForm_ok;
		private System.Windows.Forms.Button buttonGroupForm_cancel;
		private System.Windows.Forms.TextBox textBoxGroupForm_groupName;
		private System.Windows.Forms.CheckedListBox clbGroupForm_learningDays;
		private System.Windows.Forms.DateTimePicker dtpGroupForm_startTime;
		private System.Windows.Forms.ComboBox comboBoxGroupForm_direction;
	}
}