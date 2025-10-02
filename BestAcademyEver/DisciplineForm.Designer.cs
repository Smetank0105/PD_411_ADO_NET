namespace BestAcademyEver
{
	partial class DisciplineForm
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
			this.labelDisciplineForm_disciplineName = new System.Windows.Forms.Label();
			this.textBoxDisciplineForm_numberOfLessons = new System.Windows.Forms.TextBox();
			this.labelDisciplineForm_numberOfLessons = new System.Windows.Forms.Label();
			this.textBoxDisciplineForm_disciplineName = new System.Windows.Forms.TextBox();
			this.buttonDisciplineForm_ok = new System.Windows.Forms.Button();
			this.buttonDisciplineForm_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelDisciplineForm_disciplineName
			// 
			this.labelDisciplineForm_disciplineName.AutoSize = true;
			this.labelDisciplineForm_disciplineName.Location = new System.Drawing.Point(12, 16);
			this.labelDisciplineForm_disciplineName.Name = "labelDisciplineForm_disciplineName";
			this.labelDisciplineForm_disciplineName.Size = new System.Drawing.Size(70, 13);
			this.labelDisciplineForm_disciplineName.TabIndex = 0;
			this.labelDisciplineForm_disciplineName.Text = "Дисциплина";
			// 
			// textBoxDisciplineForm_numberOfLessons
			// 
			this.textBoxDisciplineForm_numberOfLessons.Location = new System.Drawing.Point(134, 43);
			this.textBoxDisciplineForm_numberOfLessons.Name = "textBoxDisciplineForm_numberOfLessons";
			this.textBoxDisciplineForm_numberOfLessons.Size = new System.Drawing.Size(206, 20);
			this.textBoxDisciplineForm_numberOfLessons.TabIndex = 1;
			// 
			// labelDisciplineForm_numberOfLessons
			// 
			this.labelDisciplineForm_numberOfLessons.AutoSize = true;
			this.labelDisciplineForm_numberOfLessons.Location = new System.Drawing.Point(12, 46);
			this.labelDisciplineForm_numberOfLessons.Name = "labelDisciplineForm_numberOfLessons";
			this.labelDisciplineForm_numberOfLessons.Size = new System.Drawing.Size(116, 13);
			this.labelDisciplineForm_numberOfLessons.TabIndex = 2;
			this.labelDisciplineForm_numberOfLessons.Text = "Колличество занятий";
			// 
			// textBoxDisciplineForm_disciplineName
			// 
			this.textBoxDisciplineForm_disciplineName.Location = new System.Drawing.Point(88, 12);
			this.textBoxDisciplineForm_disciplineName.Name = "textBoxDisciplineForm_disciplineName";
			this.textBoxDisciplineForm_disciplineName.Size = new System.Drawing.Size(252, 20);
			this.textBoxDisciplineForm_disciplineName.TabIndex = 3;
			// 
			// buttonDisciplineForm_ok
			// 
			this.buttonDisciplineForm_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonDisciplineForm_ok.Location = new System.Drawing.Point(176, 69);
			this.buttonDisciplineForm_ok.Name = "buttonDisciplineForm_ok";
			this.buttonDisciplineForm_ok.Size = new System.Drawing.Size(75, 23);
			this.buttonDisciplineForm_ok.TabIndex = 4;
			this.buttonDisciplineForm_ok.Text = "Ok";
			this.buttonDisciplineForm_ok.UseVisualStyleBackColor = true;
			// 
			// buttonDisciplineForm_cancel
			// 
			this.buttonDisciplineForm_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonDisciplineForm_cancel.Location = new System.Drawing.Point(265, 69);
			this.buttonDisciplineForm_cancel.Name = "buttonDisciplineForm_cancel";
			this.buttonDisciplineForm_cancel.Size = new System.Drawing.Size(75, 23);
			this.buttonDisciplineForm_cancel.TabIndex = 5;
			this.buttonDisciplineForm_cancel.Text = "Cancel";
			this.buttonDisciplineForm_cancel.UseVisualStyleBackColor = true;
			// 
			// DisciplineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 106);
			this.Controls.Add(this.buttonDisciplineForm_cancel);
			this.Controls.Add(this.buttonDisciplineForm_ok);
			this.Controls.Add(this.textBoxDisciplineForm_disciplineName);
			this.Controls.Add(this.labelDisciplineForm_numberOfLessons);
			this.Controls.Add(this.textBoxDisciplineForm_numberOfLessons);
			this.Controls.Add(this.labelDisciplineForm_disciplineName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DisciplineForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DisciplineForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDisciplineForm_disciplineName;
		private System.Windows.Forms.TextBox textBoxDisciplineForm_numberOfLessons;
		private System.Windows.Forms.Label labelDisciplineForm_numberOfLessons;
		private System.Windows.Forms.TextBox textBoxDisciplineForm_disciplineName;
		private System.Windows.Forms.Button buttonDisciplineForm_ok;
		private System.Windows.Forms.Button buttonDisciplineForm_cancel;
	}
}