namespace Academy
{
	partial class BaseHumanForm
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
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.buttonBrowsPhoto = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPhoto.Location = new System.Drawing.Point(394, 12);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(200, 231);
			this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPhoto.TabIndex = 27;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(104, 187);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(273, 20);
			this.textBoxPhone.TabIndex = 26;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(104, 152);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(273, 20);
			this.textBoxEmail.TabIndex = 25;
			// 
			// dateTimePickerBirthDate
			// 
			this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBirthDate.Location = new System.Drawing.Point(104, 117);
			this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
			this.dateTimePickerBirthDate.Size = new System.Drawing.Size(273, 20);
			this.dateTimePickerBirthDate.TabIndex = 24;
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.Location = new System.Drawing.Point(104, 82);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(273, 20);
			this.textBoxMiddleName.TabIndex = 23;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(104, 47);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(273, 20);
			this.textBoxFirstName.TabIndex = 22;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(104, 12);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(273, 20);
			this.textBoxLastName.TabIndex = 21;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(46, 191);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(52, 13);
			this.labelPhone.TabIndex = 20;
			this.labelPhone.Text = "Телефон";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(63, 156);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(35, 13);
			this.labelEmail.TabIndex = 19;
			this.labelEmail.Text = "E-mail";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(12, 121);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(86, 13);
			this.labelBirthDate.TabIndex = 18;
			this.labelBirthDate.Text = "Дата рождения";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(44, 86);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
			this.labelMiddleName.TabIndex = 17;
			this.labelMiddleName.Text = "Отчество";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(69, 51);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(29, 13);
			this.labelFirstName.TabIndex = 16;
			this.labelFirstName.Text = "Имя";
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(42, 16);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(56, 13);
			this.labelLastName.TabIndex = 15;
			this.labelLastName.Text = "Фамилия";
			// 
			// buttonBrowsPhoto
			// 
			this.buttonBrowsPhoto.Location = new System.Drawing.Point(104, 312);
			this.buttonBrowsPhoto.Name = "buttonBrowsPhoto";
			this.buttonBrowsPhoto.Size = new System.Drawing.Size(273, 23);
			this.buttonBrowsPhoto.TabIndex = 28;
			this.buttonBrowsPhoto.Text = "Обзор";
			this.buttonBrowsPhoto.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(519, 312);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 30;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(438, 312);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 29;
			this.buttonOk.Text = "Ок";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelID.Location = new System.Drawing.Point(11, 309);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(27, 24);
			this.labelID.TabIndex = 31;
			this.labelID.Text = "ID";
			this.labelID.Visible = false;
			// 
			// BaseHumanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 347);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonBrowsPhoto);
			this.Controls.Add(this.pictureBoxPhoto);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.dateTimePickerBirthDate);
			this.Controls.Add(this.textBoxMiddleName);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelLastName);
			this.Name = "BaseHumanForm";
			this.Text = "BaseHumanForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		protected System.Windows.Forms.Button buttonBrowsPhoto;
		protected System.Windows.Forms.Button buttonCancel;
		protected System.Windows.Forms.Button buttonOk;
		protected System.Windows.Forms.Label labelID;
		protected System.Windows.Forms.PictureBox pictureBoxPhoto;
		protected System.Windows.Forms.TextBox textBoxPhone;
		protected System.Windows.Forms.TextBox textBoxEmail;
		protected System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
		protected System.Windows.Forms.TextBox textBoxMiddleName;
		protected System.Windows.Forms.TextBox textBoxFirstName;
		protected System.Windows.Forms.TextBox textBoxLastName;
		protected System.Windows.Forms.Label labelPhone;
		protected System.Windows.Forms.Label labelEmail;
		protected System.Windows.Forms.Label labelBirthDate;
		protected System.Windows.Forms.Label labelMiddleName;
		protected System.Windows.Forms.Label labelFirstName;
		protected System.Windows.Forms.Label labelLastName;
	}
}