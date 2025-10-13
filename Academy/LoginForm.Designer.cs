namespace Academy
{
	partial class LoginForm
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
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(13, 14);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(33, 13);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Login";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(13, 52);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(53, 13);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Password";
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(96, 10);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(250, 20);
			this.textBoxLogin.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(96, 48);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(250, 20);
			this.textBoxPassword.TabIndex = 3;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 116);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
	}
}