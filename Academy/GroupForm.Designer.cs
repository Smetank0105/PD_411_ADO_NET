namespace Academy
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
			this.labelGroups_groupName = new System.Windows.Forms.Label();
			this.labelGroups_direction = new System.Windows.Forms.Label();
			this.labelGroups_learningDays = new System.Windows.Forms.Label();
			this.labelGroups_startTime = new System.Windows.Forms.Label();
			this.textBoxGroups_groupName = new System.Windows.Forms.TextBox();
			this.buttonGroups_OK = new System.Windows.Forms.Button();
			this.buttonGroups_CANCEL = new System.Windows.Forms.Button();
			this.comboBoxGroups_direction = new System.Windows.Forms.ComboBox();
			this.dateTimePickerGroups_startTime = new System.Windows.Forms.DateTimePicker();
			this.checkedListBoxGroups_learningDays = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// labelGroups_groupName
			// 
			this.labelGroups_groupName.AutoSize = true;
			this.labelGroups_groupName.Location = new System.Drawing.Point(12, 12);
			this.labelGroups_groupName.Name = "labelGroups_groupName";
			this.labelGroups_groupName.Size = new System.Drawing.Size(97, 13);
			this.labelGroups_groupName.TabIndex = 0;
			this.labelGroups_groupName.Text = "Название Группы";
			// 
			// labelGroups_direction
			// 
			this.labelGroups_direction.AutoSize = true;
			this.labelGroups_direction.Location = new System.Drawing.Point(12, 68);
			this.labelGroups_direction.Name = "labelGroups_direction";
			this.labelGroups_direction.Size = new System.Drawing.Size(75, 13);
			this.labelGroups_direction.TabIndex = 1;
			this.labelGroups_direction.Text = "Направление";
			// 
			// labelGroups_learningDays
			// 
			this.labelGroups_learningDays.AutoSize = true;
			this.labelGroups_learningDays.Location = new System.Drawing.Point(12, 171);
			this.labelGroups_learningDays.Name = "labelGroups_learningDays";
			this.labelGroups_learningDays.Size = new System.Drawing.Size(73, 13);
			this.labelGroups_learningDays.TabIndex = 2;
			this.labelGroups_learningDays.Text = "Учебные дни";
			// 
			// labelGroups_startTime
			// 
			this.labelGroups_startTime.AutoSize = true;
			this.labelGroups_startTime.Location = new System.Drawing.Point(12, 277);
			this.labelGroups_startTime.Name = "labelGroups_startTime";
			this.labelGroups_startTime.Size = new System.Drawing.Size(88, 13);
			this.labelGroups_startTime.TabIndex = 3;
			this.labelGroups_startTime.Text = "Начало занятий";
			// 
			// textBoxGroups_groupName
			// 
			this.textBoxGroups_groupName.Location = new System.Drawing.Point(119, 8);
			this.textBoxGroups_groupName.Name = "textBoxGroups_groupName";
			this.textBoxGroups_groupName.Size = new System.Drawing.Size(200, 20);
			this.textBoxGroups_groupName.TabIndex = 4;
			// 
			// buttonGroups_OK
			// 
			this.buttonGroups_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonGroups_OK.Location = new System.Drawing.Point(163, 321);
			this.buttonGroups_OK.Name = "buttonGroups_OK";
			this.buttonGroups_OK.Size = new System.Drawing.Size(75, 23);
			this.buttonGroups_OK.TabIndex = 5;
			this.buttonGroups_OK.Text = "OK";
			this.buttonGroups_OK.UseVisualStyleBackColor = true;
			// 
			// buttonGroups_CANCEL
			// 
			this.buttonGroups_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonGroups_CANCEL.Location = new System.Drawing.Point(244, 321);
			this.buttonGroups_CANCEL.Name = "buttonGroups_CANCEL";
			this.buttonGroups_CANCEL.Size = new System.Drawing.Size(75, 23);
			this.buttonGroups_CANCEL.TabIndex = 6;
			this.buttonGroups_CANCEL.Text = "CANCEL";
			this.buttonGroups_CANCEL.UseVisualStyleBackColor = true;
			// 
			// comboBoxGroups_direction
			// 
			this.comboBoxGroups_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroups_direction.FormattingEnabled = true;
			this.comboBoxGroups_direction.Location = new System.Drawing.Point(119, 64);
			this.comboBoxGroups_direction.Name = "comboBoxGroups_direction";
			this.comboBoxGroups_direction.Size = new System.Drawing.Size(200, 21);
			this.comboBoxGroups_direction.TabIndex = 7;
			// 
			// dateTimePickerGroups_startTime
			// 
			this.dateTimePickerGroups_startTime.CustomFormat = "      HH:mm";
			this.dateTimePickerGroups_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerGroups_startTime.Location = new System.Drawing.Point(119, 273);
			this.dateTimePickerGroups_startTime.MinDate = new System.DateTime(2025, 9, 23, 0, 0, 0, 0);
			this.dateTimePickerGroups_startTime.Name = "dateTimePickerGroups_startTime";
			this.dateTimePickerGroups_startTime.ShowUpDown = true;
			this.dateTimePickerGroups_startTime.Size = new System.Drawing.Size(81, 20);
			this.dateTimePickerGroups_startTime.TabIndex = 9;
			// 
			// checkedListBoxGroups_learningDays
			// 
			this.checkedListBoxGroups_learningDays.CheckOnClick = true;
			this.checkedListBoxGroups_learningDays.FormattingEnabled = true;
			this.checkedListBoxGroups_learningDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
			this.checkedListBoxGroups_learningDays.Location = new System.Drawing.Point(119, 123);
			this.checkedListBoxGroups_learningDays.Name = "checkedListBoxGroups_learningDays";
			this.checkedListBoxGroups_learningDays.Size = new System.Drawing.Size(100, 109);
			this.checkedListBoxGroups_learningDays.TabIndex = 10;
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 356);
			this.Controls.Add(this.checkedListBoxGroups_learningDays);
			this.Controls.Add(this.dateTimePickerGroups_startTime);
			this.Controls.Add(this.comboBoxGroups_direction);
			this.Controls.Add(this.buttonGroups_CANCEL);
			this.Controls.Add(this.buttonGroups_OK);
			this.Controls.Add(this.textBoxGroups_groupName);
			this.Controls.Add(this.labelGroups_startTime);
			this.Controls.Add(this.labelGroups_learningDays);
			this.Controls.Add(this.labelGroups_direction);
			this.Controls.Add(this.labelGroups_groupName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "GroupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroups_groupName;
		private System.Windows.Forms.Label labelGroups_direction;
		private System.Windows.Forms.Label labelGroups_learningDays;
		private System.Windows.Forms.Label labelGroups_startTime;
		private System.Windows.Forms.TextBox textBoxGroups_groupName;
		private System.Windows.Forms.Button buttonGroups_OK;
		private System.Windows.Forms.Button buttonGroups_CANCEL;
		private System.Windows.Forms.ComboBox comboBoxGroups_direction;
		private System.Windows.Forms.DateTimePicker dateTimePickerGroups_startTime;
		private System.Windows.Forms.CheckedListBox checkedListBoxGroups_learningDays;
	}
}