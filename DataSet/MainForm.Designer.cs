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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPageDIsciplines = new System.Windows.Forms.TabPage();
			this.comboBoxDisciplinesForDirection = new System.Windows.Forms.ComboBox();
			this.dataGridViewDisciplines = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPageDIsciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxStudentsDirection
			// 
			this.comboBoxStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudentsDirection.FormattingEnabled = true;
			this.comboBoxStudentsDirection.Location = new System.Drawing.Point(228, 6);
			this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
			this.comboBoxStudentsDirection.Size = new System.Drawing.Size(286, 21);
			this.comboBoxStudentsDirection.TabIndex = 0;
			this.comboBoxStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsDirection_SelectedIndexChanged);
			// 
			// comboBoxStudentsGroup
			// 
			this.comboBoxStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStudentsGroup.FormattingEnabled = true;
			this.comboBoxStudentsGroup.Location = new System.Drawing.Point(6, 6);
			this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
			this.comboBoxStudentsGroup.Size = new System.Drawing.Size(216, 21);
			this.comboBoxStudentsGroup.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPageDIsciplines);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(776, 413);
			this.tabControl.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.comboBoxStudentsGroup);
			this.tabPage1.Controls.Add(this.comboBoxStudentsDirection);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 387);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 387);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(768, 387);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPageDIsciplines
			// 
			this.tabPageDIsciplines.Controls.Add(this.dataGridViewDisciplines);
			this.tabPageDIsciplines.Controls.Add(this.comboBoxDisciplinesForDirection);
			this.tabPageDIsciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDIsciplines.Name = "tabPageDIsciplines";
			this.tabPageDIsciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDIsciplines.Size = new System.Drawing.Size(768, 387);
			this.tabPageDIsciplines.TabIndex = 3;
			this.tabPageDIsciplines.Text = "Disciplines";
			this.tabPageDIsciplines.UseVisualStyleBackColor = true;
			// 
			// comboBoxDisciplinesForDirection
			// 
			this.comboBoxDisciplinesForDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDisciplinesForDirection.FormattingEnabled = true;
			this.comboBoxDisciplinesForDirection.Location = new System.Drawing.Point(7, 7);
			this.comboBoxDisciplinesForDirection.Name = "comboBoxDisciplinesForDirection";
			this.comboBoxDisciplinesForDirection.Size = new System.Drawing.Size(283, 21);
			this.comboBoxDisciplinesForDirection.TabIndex = 0;
			this.comboBoxDisciplinesForDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplinesForDirection_SelectedIndexChanged);
			// 
			// dataGridViewDisciplines
			// 
			this.dataGridViewDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDisciplines.Location = new System.Drawing.Point(3, 34);
			this.dataGridViewDisciplines.Name = "dataGridViewDisciplines";
			this.dataGridViewDisciplines.Size = new System.Drawing.Size(762, 357);
			this.dataGridViewDisciplines.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPageDIsciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisciplines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPageDIsciplines;
		private System.Windows.Forms.DataGridView dataGridViewDisciplines;
		private System.Windows.Forms.ComboBox comboBoxDisciplinesForDirection;
	}
}

