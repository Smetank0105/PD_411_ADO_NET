namespace BestAcademyEver
{
	partial class DirectionForm
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
			this.labelDirectionForm_directionName = new System.Windows.Forms.Label();
			this.textBoxDirectionForm_directionName = new System.Windows.Forms.TextBox();
			this.buttonDirectionForm_ok = new System.Windows.Forms.Button();
			this.buttonDirectionForm_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelDirectionForm_directionName
			// 
			this.labelDirectionForm_directionName.AutoSize = true;
			this.labelDirectionForm_directionName.Location = new System.Drawing.Point(12, 16);
			this.labelDirectionForm_directionName.Name = "labelDirectionForm_directionName";
			this.labelDirectionForm_directionName.Size = new System.Drawing.Size(75, 13);
			this.labelDirectionForm_directionName.TabIndex = 0;
			this.labelDirectionForm_directionName.Text = "Направление";
			// 
			// textBoxDirectionForm_directionName
			// 
			this.textBoxDirectionForm_directionName.Location = new System.Drawing.Point(93, 12);
			this.textBoxDirectionForm_directionName.Name = "textBoxDirectionForm_directionName";
			this.textBoxDirectionForm_directionName.Size = new System.Drawing.Size(302, 20);
			this.textBoxDirectionForm_directionName.TabIndex = 1;
			// 
			// buttonDirectionForm_ok
			// 
			this.buttonDirectionForm_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonDirectionForm_ok.Location = new System.Drawing.Point(239, 51);
			this.buttonDirectionForm_ok.Name = "buttonDirectionForm_ok";
			this.buttonDirectionForm_ok.Size = new System.Drawing.Size(75, 23);
			this.buttonDirectionForm_ok.TabIndex = 2;
			this.buttonDirectionForm_ok.Text = "Ok";
			this.buttonDirectionForm_ok.UseVisualStyleBackColor = true;
			// 
			// buttonDirectionForm_cancel
			// 
			this.buttonDirectionForm_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonDirectionForm_cancel.Location = new System.Drawing.Point(320, 51);
			this.buttonDirectionForm_cancel.Name = "buttonDirectionForm_cancel";
			this.buttonDirectionForm_cancel.Size = new System.Drawing.Size(75, 23);
			this.buttonDirectionForm_cancel.TabIndex = 3;
			this.buttonDirectionForm_cancel.Text = "Cancel";
			this.buttonDirectionForm_cancel.UseVisualStyleBackColor = true;
			// 
			// DirectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 89);
			this.Controls.Add(this.buttonDirectionForm_cancel);
			this.Controls.Add(this.buttonDirectionForm_ok);
			this.Controls.Add(this.textBoxDirectionForm_directionName);
			this.Controls.Add(this.labelDirectionForm_directionName);
			this.Name = "DirectionForm";
			this.Text = "DirectionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDirectionForm_directionName;
		private System.Windows.Forms.TextBox textBoxDirectionForm_directionName;
		private System.Windows.Forms.Button buttonDirectionForm_ok;
		private System.Windows.Forms.Button buttonDirectionForm_cancel;
	}
}