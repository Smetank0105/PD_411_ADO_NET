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
			this.labelGroup_direction = new System.Windows.Forms.Label();
			this.labelGroup_learningDays = new System.Windows.Forms.Label();
			this.labelGroup_startTime = new System.Windows.Forms.Label();
			this.textBoxGroup_groupName = new System.Windows.Forms.TextBox();
			this.comboBoxGroup_direction = new System.Windows.Forms.ComboBox();
			this.checkedListBoxGroup_learningDays = new System.Windows.Forms.CheckedListBox();
			this.dateTimePickerGroup_startTime = new System.Windows.Forms.DateTimePicker();
			this.buttonGroup_Ok = new System.Windows.Forms.Button();
			this.buttonGroup_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelGroups_groupName
			// 
			this.labelGroups_groupName.AutoSize = true;
			this.labelGroups_groupName.Location = new System.Drawing.Point(20, 20);
			this.labelGroups_groupName.Name = "labelGroups_groupName";
			this.labelGroups_groupName.Size = new System.Drawing.Size(96, 13);
			this.labelGroups_groupName.TabIndex = 0;
			this.labelGroups_groupName.Text = "Название группы";
			// 
			// labelGroup_direction
			// 
			this.labelGroup_direction.AutoSize = true;
			this.labelGroup_direction.Location = new System.Drawing.Point(20, 60);
			this.labelGroup_direction.Name = "labelGroup_direction";
			this.labelGroup_direction.Size = new System.Drawing.Size(75, 13);
			this.labelGroup_direction.TabIndex = 1;
			this.labelGroup_direction.Text = "Направление";
			// 
			// labelGroup_learningDays
			// 
			this.labelGroup_learningDays.AutoSize = true;
			this.labelGroup_learningDays.Location = new System.Drawing.Point(20, 141);
			this.labelGroup_learningDays.Name = "labelGroup_learningDays";
			this.labelGroup_learningDays.Size = new System.Drawing.Size(73, 13);
			this.labelGroup_learningDays.TabIndex = 2;
			this.labelGroup_learningDays.Text = "Учебные дни";
			// 
			// labelGroup_startTime
			// 
			this.labelGroup_startTime.AutoSize = true;
			this.labelGroup_startTime.Location = new System.Drawing.Point(20, 222);
			this.labelGroup_startTime.Name = "labelGroup_startTime";
			this.labelGroup_startTime.Size = new System.Drawing.Size(88, 13);
			this.labelGroup_startTime.TabIndex = 3;
			this.labelGroup_startTime.Text = "Начало занятий";
			// 
			// textBoxGroup_groupName
			// 
			this.textBoxGroup_groupName.Location = new System.Drawing.Point(130, 16);
			this.textBoxGroup_groupName.Name = "textBoxGroup_groupName";
			this.textBoxGroup_groupName.Size = new System.Drawing.Size(100, 20);
			this.textBoxGroup_groupName.TabIndex = 4;
			// 
			// comboBoxGroup_direction
			// 
			this.comboBoxGroup_direction.FormattingEnabled = true;
			this.comboBoxGroup_direction.Location = new System.Drawing.Point(130, 56);
			this.comboBoxGroup_direction.Name = "comboBoxGroup_direction";
			this.comboBoxGroup_direction.Size = new System.Drawing.Size(121, 21);
			this.comboBoxGroup_direction.TabIndex = 5;
			// 
			// checkedListBoxGroup_learningDays
			// 
			this.checkedListBoxGroup_learningDays.CheckOnClick = true;
			this.checkedListBoxGroup_learningDays.FormattingEnabled = true;
			this.checkedListBoxGroup_learningDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
			this.checkedListBoxGroup_learningDays.Location = new System.Drawing.Point(130, 100);
			this.checkedListBoxGroup_learningDays.Name = "checkedListBoxGroup_learningDays";
			this.checkedListBoxGroup_learningDays.Size = new System.Drawing.Size(120, 94);
			this.checkedListBoxGroup_learningDays.TabIndex = 6;
			// 
			// dateTimePickerGroup_startTime
			// 
			this.dateTimePickerGroup_startTime.CustomFormat = "  HH:mm";
			this.dateTimePickerGroup_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerGroup_startTime.Location = new System.Drawing.Point(130, 218);
			this.dateTimePickerGroup_startTime.Name = "dateTimePickerGroup_startTime";
			this.dateTimePickerGroup_startTime.Size = new System.Drawing.Size(61, 20);
			this.dateTimePickerGroup_startTime.TabIndex = 7;
			// 
			// buttonGroup_Ok
			// 
			this.buttonGroup_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonGroup_Ok.Location = new System.Drawing.Point(130, 269);
			this.buttonGroup_Ok.Name = "buttonGroup_Ok";
			this.buttonGroup_Ok.Size = new System.Drawing.Size(75, 23);
			this.buttonGroup_Ok.TabIndex = 8;
			this.buttonGroup_Ok.Text = "Ok";
			this.buttonGroup_Ok.UseVisualStyleBackColor = true;
			// 
			// buttonGroup_Cancel
			// 
			this.buttonGroup_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonGroup_Cancel.Location = new System.Drawing.Point(211, 269);
			this.buttonGroup_Cancel.Name = "buttonGroup_Cancel";
			this.buttonGroup_Cancel.Size = new System.Drawing.Size(75, 23);
			this.buttonGroup_Cancel.TabIndex = 9;
			this.buttonGroup_Cancel.Text = "Cancel";
			this.buttonGroup_Cancel.UseVisualStyleBackColor = true;
			// 
			// GroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 304);
			this.Controls.Add(this.buttonGroup_Cancel);
			this.Controls.Add(this.buttonGroup_Ok);
			this.Controls.Add(this.dateTimePickerGroup_startTime);
			this.Controls.Add(this.checkedListBoxGroup_learningDays);
			this.Controls.Add(this.comboBoxGroup_direction);
			this.Controls.Add(this.textBoxGroup_groupName);
			this.Controls.Add(this.labelGroup_startTime);
			this.Controls.Add(this.labelGroup_learningDays);
			this.Controls.Add(this.labelGroup_direction);
			this.Controls.Add(this.labelGroups_groupName);
			this.Name = "GroupForm";
			this.Text = "GroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroups_groupName;
		private System.Windows.Forms.Label labelGroup_direction;
		private System.Windows.Forms.Label labelGroup_learningDays;
		private System.Windows.Forms.Label labelGroup_startTime;
		private System.Windows.Forms.TextBox textBoxGroup_groupName;
		private System.Windows.Forms.ComboBox comboBoxGroup_direction;
		private System.Windows.Forms.CheckedListBox checkedListBoxGroup_learningDays;
		private System.Windows.Forms.DateTimePicker dateTimePickerGroup_startTime;
		private System.Windows.Forms.Button buttonGroup_Ok;
		private System.Windows.Forms.Button buttonGroup_Cancel;
	}
}