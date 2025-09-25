namespace Academy
{
	partial class StudentForm
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
			this.labelStudent_lastName = new System.Windows.Forms.Label();
			this.labelStudent_firstName = new System.Windows.Forms.Label();
			this.labelStudent_middleName = new System.Windows.Forms.Label();
			this.labelStudent_birthDate = new System.Windows.Forms.Label();
			this.labelStudent_email = new System.Windows.Forms.Label();
			this.labelStudent_phone = new System.Windows.Forms.Label();
			this.labelStudent_group = new System.Windows.Forms.Label();
			this.textBoxStudent_lastName = new System.Windows.Forms.TextBox();
			this.textBoxStudent_middleName = new System.Windows.Forms.TextBox();
			this.textBoxStudent_firstName = new System.Windows.Forms.TextBox();
			this.textBoxStudent_email = new System.Windows.Forms.TextBox();
			this.buttonStudent_Ok = new System.Windows.Forms.Button();
			this.buttonSudent_Cancel = new System.Windows.Forms.Button();
			this.comboBoxStudent_group = new System.Windows.Forms.ComboBox();
			this.textBoxStudent_phone = new System.Windows.Forms.TextBox();
			this.dateTimePickerStudent_birthDate = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// labelStudent_lastName
			// 
			this.labelStudent_lastName.AutoSize = true;
			this.labelStudent_lastName.Location = new System.Drawing.Point(20, 20);
			this.labelStudent_lastName.Name = "labelStudent_lastName";
			this.labelStudent_lastName.Size = new System.Drawing.Size(56, 13);
			this.labelStudent_lastName.TabIndex = 0;
			this.labelStudent_lastName.Text = "Фамилия";
			// 
			// labelStudent_firstName
			// 
			this.labelStudent_firstName.AutoSize = true;
			this.labelStudent_firstName.Location = new System.Drawing.Point(20, 60);
			this.labelStudent_firstName.Name = "labelStudent_firstName";
			this.labelStudent_firstName.Size = new System.Drawing.Size(29, 13);
			this.labelStudent_firstName.TabIndex = 1;
			this.labelStudent_firstName.Text = "Имя";
			// 
			// labelStudent_middleName
			// 
			this.labelStudent_middleName.AutoSize = true;
			this.labelStudent_middleName.Location = new System.Drawing.Point(20, 100);
			this.labelStudent_middleName.Name = "labelStudent_middleName";
			this.labelStudent_middleName.Size = new System.Drawing.Size(54, 13);
			this.labelStudent_middleName.TabIndex = 2;
			this.labelStudent_middleName.Text = "Отчество";
			// 
			// labelStudent_birthDate
			// 
			this.labelStudent_birthDate.AutoSize = true;
			this.labelStudent_birthDate.Location = new System.Drawing.Point(20, 140);
			this.labelStudent_birthDate.Name = "labelStudent_birthDate";
			this.labelStudent_birthDate.Size = new System.Drawing.Size(86, 13);
			this.labelStudent_birthDate.TabIndex = 3;
			this.labelStudent_birthDate.Text = "Дата рождения";
			// 
			// labelStudent_email
			// 
			this.labelStudent_email.AutoSize = true;
			this.labelStudent_email.Location = new System.Drawing.Point(20, 180);
			this.labelStudent_email.Name = "labelStudent_email";
			this.labelStudent_email.Size = new System.Drawing.Size(32, 13);
			this.labelStudent_email.TabIndex = 4;
			this.labelStudent_email.Text = "Email";
			// 
			// labelStudent_phone
			// 
			this.labelStudent_phone.AutoSize = true;
			this.labelStudent_phone.Location = new System.Drawing.Point(20, 220);
			this.labelStudent_phone.Name = "labelStudent_phone";
			this.labelStudent_phone.Size = new System.Drawing.Size(52, 13);
			this.labelStudent_phone.TabIndex = 5;
			this.labelStudent_phone.Text = "Телефон";
			// 
			// labelStudent_group
			// 
			this.labelStudent_group.AutoSize = true;
			this.labelStudent_group.Location = new System.Drawing.Point(20, 260);
			this.labelStudent_group.Name = "labelStudent_group";
			this.labelStudent_group.Size = new System.Drawing.Size(42, 13);
			this.labelStudent_group.TabIndex = 6;
			this.labelStudent_group.Text = "Группа";
			// 
			// textBoxStudent_lastName
			// 
			this.textBoxStudent_lastName.Location = new System.Drawing.Point(144, 16);
			this.textBoxStudent_lastName.Name = "textBoxStudent_lastName";
			this.textBoxStudent_lastName.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudent_lastName.TabIndex = 7;
			// 
			// textBoxStudent_middleName
			// 
			this.textBoxStudent_middleName.Location = new System.Drawing.Point(144, 96);
			this.textBoxStudent_middleName.Name = "textBoxStudent_middleName";
			this.textBoxStudent_middleName.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudent_middleName.TabIndex = 8;
			// 
			// textBoxStudent_firstName
			// 
			this.textBoxStudent_firstName.Location = new System.Drawing.Point(144, 56);
			this.textBoxStudent_firstName.Name = "textBoxStudent_firstName";
			this.textBoxStudent_firstName.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudent_firstName.TabIndex = 9;
			// 
			// textBoxStudent_email
			// 
			this.textBoxStudent_email.Location = new System.Drawing.Point(144, 176);
			this.textBoxStudent_email.Name = "textBoxStudent_email";
			this.textBoxStudent_email.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudent_email.TabIndex = 10;
			// 
			// buttonStudent_Ok
			// 
			this.buttonStudent_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonStudent_Ok.Location = new System.Drawing.Point(144, 300);
			this.buttonStudent_Ok.Name = "buttonStudent_Ok";
			this.buttonStudent_Ok.Size = new System.Drawing.Size(75, 23);
			this.buttonStudent_Ok.TabIndex = 13;
			this.buttonStudent_Ok.Text = "Ok";
			this.buttonStudent_Ok.UseVisualStyleBackColor = true;
			// 
			// buttonSudent_Cancel
			// 
			this.buttonSudent_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonSudent_Cancel.Location = new System.Drawing.Point(225, 300);
			this.buttonSudent_Cancel.Name = "buttonSudent_Cancel";
			this.buttonSudent_Cancel.Size = new System.Drawing.Size(75, 23);
			this.buttonSudent_Cancel.TabIndex = 14;
			this.buttonSudent_Cancel.Text = "Cancel";
			this.buttonSudent_Cancel.UseVisualStyleBackColor = true;
			// 
			// comboBoxStudent_group
			// 
			this.comboBoxStudent_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudent_group.FormattingEnabled = true;
			this.comboBoxStudent_group.Location = new System.Drawing.Point(144, 256);
			this.comboBoxStudent_group.Name = "comboBoxStudent_group";
			this.comboBoxStudent_group.Size = new System.Drawing.Size(100, 21);
			this.comboBoxStudent_group.TabIndex = 15;
			// 
			// textBoxStudent_phone
			// 
			this.textBoxStudent_phone.Location = new System.Drawing.Point(144, 216);
			this.textBoxStudent_phone.Name = "textBoxStudent_phone";
			this.textBoxStudent_phone.Size = new System.Drawing.Size(100, 20);
			this.textBoxStudent_phone.TabIndex = 16;
			// 
			// dateTimePickerStudent_birthDate
			// 
			this.dateTimePickerStudent_birthDate.CustomFormat = "yyyy-MM-dd";
			this.dateTimePickerStudent_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStudent_birthDate.Location = new System.Drawing.Point(144, 136);
			this.dateTimePickerStudent_birthDate.Name = "dateTimePickerStudent_birthDate";
			this.dateTimePickerStudent_birthDate.Size = new System.Drawing.Size(100, 20);
			this.dateTimePickerStudent_birthDate.TabIndex = 17;
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 334);
			this.Controls.Add(this.dateTimePickerStudent_birthDate);
			this.Controls.Add(this.textBoxStudent_phone);
			this.Controls.Add(this.comboBoxStudent_group);
			this.Controls.Add(this.buttonSudent_Cancel);
			this.Controls.Add(this.buttonStudent_Ok);
			this.Controls.Add(this.textBoxStudent_email);
			this.Controls.Add(this.textBoxStudent_firstName);
			this.Controls.Add(this.textBoxStudent_middleName);
			this.Controls.Add(this.textBoxStudent_lastName);
			this.Controls.Add(this.labelStudent_group);
			this.Controls.Add(this.labelStudent_phone);
			this.Controls.Add(this.labelStudent_email);
			this.Controls.Add(this.labelStudent_birthDate);
			this.Controls.Add(this.labelStudent_middleName);
			this.Controls.Add(this.labelStudent_firstName);
			this.Controls.Add(this.labelStudent_lastName);
			this.Name = "StudentForm";
			this.Text = "StudentForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStudent_lastName;
		private System.Windows.Forms.Label labelStudent_firstName;
		private System.Windows.Forms.Label labelStudent_middleName;
		private System.Windows.Forms.Label labelStudent_birthDate;
		private System.Windows.Forms.Label labelStudent_email;
		private System.Windows.Forms.Label labelStudent_phone;
		private System.Windows.Forms.Label labelStudent_group;
		private System.Windows.Forms.TextBox textBoxStudent_lastName;
		private System.Windows.Forms.TextBox textBoxStudent_middleName;
		private System.Windows.Forms.TextBox textBoxStudent_firstName;
		private System.Windows.Forms.TextBox textBoxStudent_email;
		private System.Windows.Forms.Button buttonStudent_Ok;
		private System.Windows.Forms.Button buttonSudent_Cancel;
		private System.Windows.Forms.ComboBox comboBoxStudent_group;
		private System.Windows.Forms.TextBox textBoxStudent_phone;
		private System.Windows.Forms.DateTimePicker dateTimePickerStudent_birthDate;
	}
}