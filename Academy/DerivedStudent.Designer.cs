namespace Academy
{
	partial class DerivedStudent
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
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.labelGroup = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonBrowsPhoto
			// 
			this.buttonBrowsPhoto.Location = new System.Drawing.Point(104, 263);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(519, 263);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(438, 263);
			// 
			// labelID
			// 
			this.labelID.Location = new System.Drawing.Point(11, 260);
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(104, 222);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(273, 21);
			this.comboBoxGroup.TabIndex = 33;
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(56, 225);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(42, 13);
			this.labelGroup.TabIndex = 32;
			this.labelGroup.Text = "Группа";
			// 
			// DerivedStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 299);
			this.Controls.Add(this.comboBoxGroup);
			this.Controls.Add(this.labelGroup);
			this.Name = "DerivedStudent";
			this.Text = "DerivedStudent";
			this.Controls.SetChildIndex(this.buttonBrowsPhoto, 0);
			this.Controls.SetChildIndex(this.buttonOk, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			this.Controls.SetChildIndex(this.labelID, 0);
			this.Controls.SetChildIndex(this.labelGroup, 0);
			this.Controls.SetChildIndex(this.comboBoxGroup, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.Label labelGroup;
	}
}