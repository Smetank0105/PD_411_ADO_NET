namespace DataSet
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
			this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
			this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBoxStudentsDirection
			// 
			this.comboBoxStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudentsDirection.FormattingEnabled = true;
			this.comboBoxStudentsDirection.Location = new System.Drawing.Point(234, 12);
			this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
			this.comboBoxStudentsDirection.Size = new System.Drawing.Size(286, 21);
			this.comboBoxStudentsDirection.TabIndex = 0;
			this.comboBoxStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
			// 
			// comboBoxStudentsGroup
			// 
			this.comboBoxStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudentsGroup.FormattingEnabled = true;
			this.comboBoxStudentsGroup.Location = new System.Drawing.Point(12, 12);
			this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
			this.comboBoxStudentsGroup.Size = new System.Drawing.Size(216, 21);
			this.comboBoxStudentsGroup.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBoxStudentsGroup);
			this.Controls.Add(this.comboBoxStudentsDirection);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
	}
}

