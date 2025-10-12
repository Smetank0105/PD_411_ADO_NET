namespace Academy
{
	partial class DerivedTeacher
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
			this.dateTimePickerWorkSince = new System.Windows.Forms.DateTimePicker();
			this.textBoxRate = new System.Windows.Forms.TextBox();
			this.labelRate = new System.Windows.Forms.Label();
			this.labelWorkSince = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerWorkSince
			// 
			this.dateTimePickerWorkSince.CustomFormat = "yyyy-MM-dd";
			this.dateTimePickerWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerWorkSince.Location = new System.Drawing.Point(104, 222);
			this.dateTimePickerWorkSince.Name = "dateTimePickerWorkSince";
			this.dateTimePickerWorkSince.ShowUpDown = true;
			this.dateTimePickerWorkSince.Size = new System.Drawing.Size(273, 20);
			this.dateTimePickerWorkSince.TabIndex = 35;
			// 
			// textBoxRate
			// 
			this.textBoxRate.Location = new System.Drawing.Point(104, 258);
			this.textBoxRate.Name = "textBoxRate";
			this.textBoxRate.Size = new System.Drawing.Size(273, 20);
			this.textBoxRate.TabIndex = 34;
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Location = new System.Drawing.Point(30, 262);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(48, 13);
			this.labelRate.TabIndex = 33;
			this.labelRate.Text = "Рейтинг";
			// 
			// labelWorkSince
			// 
			this.labelWorkSince.AutoSize = true;
			this.labelWorkSince.Location = new System.Drawing.Point(4, 226);
			this.labelWorkSince.Name = "labelWorkSince";
			this.labelWorkSince.Size = new System.Drawing.Size(74, 13);
			this.labelWorkSince.TabIndex = 32;
			this.labelWorkSince.Text = "Опыт работы";
			// 
			// DerivedTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 350);
			this.Controls.Add(this.dateTimePickerWorkSince);
			this.Controls.Add(this.textBoxRate);
			this.Controls.Add(this.labelRate);
			this.Controls.Add(this.labelWorkSince);
			this.Name = "DerivedTeacher";
			this.Text = "DerivedTeacher";
			this.Controls.SetChildIndex(this.labelLastName, 0);
			this.Controls.SetChildIndex(this.labelFirstName, 0);
			this.Controls.SetChildIndex(this.labelMiddleName, 0);
			this.Controls.SetChildIndex(this.labelBirthDate, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.labelPhone, 0);
			this.Controls.SetChildIndex(this.textBoxLastName, 0);
			this.Controls.SetChildIndex(this.textBoxFirstName, 0);
			this.Controls.SetChildIndex(this.textBoxMiddleName, 0);
			this.Controls.SetChildIndex(this.dateTimePickerBirthDate, 0);
			this.Controls.SetChildIndex(this.textBoxEmail, 0);
			this.Controls.SetChildIndex(this.textBoxPhone, 0);
			this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
			this.Controls.SetChildIndex(this.buttonBrowsPhoto, 0);
			this.Controls.SetChildIndex(this.buttonOk, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.labelID, 0);
			this.Controls.SetChildIndex(this.labelWorkSince, 0);
			this.Controls.SetChildIndex(this.labelRate, 0);
			this.Controls.SetChildIndex(this.textBoxRate, 0);
			this.Controls.SetChildIndex(this.dateTimePickerWorkSince, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerWorkSince;
		private System.Windows.Forms.TextBox textBoxRate;
		private System.Windows.Forms.Label labelRate;
		private System.Windows.Forms.Label labelWorkSince;
	}
}