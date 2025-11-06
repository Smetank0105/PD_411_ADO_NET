namespace IPInfo
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
			this.labelIP = new System.Windows.Forms.Label();
			this.labelMask = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.labelNetwork = new System.Windows.Forms.Label();
			this.labelBroadcast = new System.Windows.Forms.Label();
			this.labelIPcount = new System.Windows.Forms.Label();
			this.labelHostcount = new System.Windows.Forms.Label();
			this.textBoxIPcount = new System.Windows.Forms.TextBox();
			this.textBoxHostcount = new System.Windows.Forms.TextBox();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.textBoxMask = new System.Windows.Forms.TextBox();
			this.textBoxNetwork = new System.Windows.Forms.TextBox();
			this.textBoxBroadcast = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIP.Location = new System.Drawing.Point(25, 31);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(102, 24);
			this.labelIP.TabIndex = 0;
			this.labelIP.Text = "IP-Address";
			// 
			// labelMask
			// 
			this.labelMask.AutoSize = true;
			this.labelMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMask.Location = new System.Drawing.Point(73, 84);
			this.labelMask.Name = "labelMask";
			this.labelMask.Size = new System.Drawing.Size(54, 24);
			this.labelMask.TabIndex = 2;
			this.labelMask.Text = "Mask";
			// 
			// button
			// 
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button.Location = new System.Drawing.Point(260, 181);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(60, 37);
			this.button.TabIndex = 4;
			this.button.Text = "Info";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// labelNetwork
			// 
			this.labelNetwork.AutoSize = true;
			this.labelNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNetwork.Location = new System.Drawing.Point(349, 31);
			this.labelNetwork.Name = "labelNetwork";
			this.labelNetwork.Size = new System.Drawing.Size(154, 24);
			this.labelNetwork.TabIndex = 5;
			this.labelNetwork.Text = "Netwrok Address";
			// 
			// labelBroadcast
			// 
			this.labelBroadcast.AutoSize = true;
			this.labelBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBroadcast.Location = new System.Drawing.Point(335, 81);
			this.labelBroadcast.Name = "labelBroadcast";
			this.labelBroadcast.Size = new System.Drawing.Size(168, 24);
			this.labelBroadcast.TabIndex = 6;
			this.labelBroadcast.Text = "Broadcast Address";
			// 
			// labelIPcount
			// 
			this.labelIPcount.AutoSize = true;
			this.labelIPcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIPcount.Location = new System.Drawing.Point(349, 131);
			this.labelIPcount.Name = "labelIPcount";
			this.labelIPcount.Size = new System.Drawing.Size(154, 24);
			this.labelIPcount.TabIndex = 7;
			this.labelIPcount.Text = "IP-Address count";
			// 
			// labelHostcount
			// 
			this.labelHostcount.AutoSize = true;
			this.labelHostcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHostcount.Location = new System.Drawing.Point(403, 181);
			this.labelHostcount.Name = "labelHostcount";
			this.labelHostcount.Size = new System.Drawing.Size(100, 24);
			this.labelHostcount.TabIndex = 8;
			this.labelHostcount.Text = "Host count";
			// 
			// textBoxIPcount
			// 
			this.textBoxIPcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxIPcount.Location = new System.Drawing.Point(533, 129);
			this.textBoxIPcount.Name = "textBoxIPcount";
			this.textBoxIPcount.ReadOnly = true;
			this.textBoxIPcount.Size = new System.Drawing.Size(100, 29);
			this.textBoxIPcount.TabIndex = 11;
			this.textBoxIPcount.TabStop = false;
			// 
			// textBoxHostcount
			// 
			this.textBoxHostcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxHostcount.Location = new System.Drawing.Point(533, 179);
			this.textBoxHostcount.Name = "textBoxHostcount";
			this.textBoxHostcount.ReadOnly = true;
			this.textBoxHostcount.Size = new System.Drawing.Size(100, 29);
			this.textBoxHostcount.TabIndex = 12;
			this.textBoxHostcount.TabStop = false;
			// 
			// textBoxIP
			// 
			this.textBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxIP.Location = new System.Drawing.Point(164, 28);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(156, 29);
			this.textBoxIP.TabIndex = 2;
			// 
			// textBoxMask
			// 
			this.textBoxMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxMask.Location = new System.Drawing.Point(164, 81);
			this.textBoxMask.Name = "textBoxMask";
			this.textBoxMask.Size = new System.Drawing.Size(156, 29);
			this.textBoxMask.TabIndex = 3;
			// 
			// textBoxNetwork
			// 
			this.textBoxNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNetwork.Location = new System.Drawing.Point(533, 28);
			this.textBoxNetwork.Name = "textBoxNetwork";
			this.textBoxNetwork.ReadOnly = true;
			this.textBoxNetwork.Size = new System.Drawing.Size(156, 29);
			this.textBoxNetwork.TabIndex = 15;
			this.textBoxNetwork.TabStop = false;
			// 
			// textBoxBroadcast
			// 
			this.textBoxBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxBroadcast.Location = new System.Drawing.Point(533, 78);
			this.textBoxBroadcast.Name = "textBoxBroadcast";
			this.textBoxBroadcast.ReadOnly = true;
			this.textBoxBroadcast.Size = new System.Drawing.Size(156, 29);
			this.textBoxBroadcast.TabIndex = 16;
			this.textBoxBroadcast.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 237);
			this.Controls.Add(this.textBoxBroadcast);
			this.Controls.Add(this.textBoxNetwork);
			this.Controls.Add(this.textBoxMask);
			this.Controls.Add(this.textBoxIP);
			this.Controls.Add(this.textBoxHostcount);
			this.Controls.Add(this.textBoxIPcount);
			this.Controls.Add(this.labelHostcount);
			this.Controls.Add(this.labelIPcount);
			this.Controls.Add(this.labelBroadcast);
			this.Controls.Add(this.labelNetwork);
			this.Controls.Add(this.button);
			this.Controls.Add(this.labelMask);
			this.Controls.Add(this.labelIP);
			this.Name = "MainForm";
			this.Text = "IPAddress";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.Label labelMask;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label labelNetwork;
		private System.Windows.Forms.Label labelBroadcast;
		private System.Windows.Forms.Label labelIPcount;
		private System.Windows.Forms.Label labelHostcount;
		private System.Windows.Forms.TextBox textBoxIPcount;
		private System.Windows.Forms.TextBox textBoxHostcount;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.TextBox textBoxMask;
		private System.Windows.Forms.TextBox textBoxNetwork;
		private System.Windows.Forms.TextBox textBoxBroadcast;
	}
}

