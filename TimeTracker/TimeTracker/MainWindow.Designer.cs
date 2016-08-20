namespace TimeTracker
{
	partial class TimeTracker
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewClientProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAllClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAllProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmbxClientName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbxClientProject = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.btnToday = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimeIn = new System.Windows.Forms.TextBox();
			this.btnNowIn = new System.Windows.Forms.Button();
			this.btnTimeOut = new System.Windows.Forms.Button();
			this.txtTimeOut = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblCurrentPunch = new System.Windows.Forms.Label();
			this.btnEditCurrentPunch = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(796, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.addNewClientProjectToolStripMenuItem,
            this.viewAllClientsToolStripMenuItem,
            this.viewAllProjectsToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
			this.clientToolStripMenuItem.Text = "Actions";
			this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
			// 
			// addNewToolStripMenuItem
			// 
			this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
			this.addNewToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.addNewToolStripMenuItem.Text = "Add New Client";
			this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
			// 
			// addNewClientProjectToolStripMenuItem
			// 
			this.addNewClientProjectToolStripMenuItem.Name = "addNewClientProjectToolStripMenuItem";
			this.addNewClientProjectToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.addNewClientProjectToolStripMenuItem.Text = "Add New Client Project";
			// 
			// viewAllClientsToolStripMenuItem
			// 
			this.viewAllClientsToolStripMenuItem.Name = "viewAllClientsToolStripMenuItem";
			this.viewAllClientsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.viewAllClientsToolStripMenuItem.Text = "View All Clients";
			this.viewAllClientsToolStripMenuItem.Click += new System.EventHandler(this.viewAllClientsToolStripMenuItem_Click);
			// 
			// viewAllProjectsToolStripMenuItem
			// 
			this.viewAllProjectsToolStripMenuItem.Name = "viewAllProjectsToolStripMenuItem";
			this.viewAllProjectsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.viewAllProjectsToolStripMenuItem.Text = "View All Projects";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// cmbxClientName
			// 
			this.cmbxClientName.FormattingEnabled = true;
			this.cmbxClientName.Location = new System.Drawing.Point(69, 133);
			this.cmbxClientName.Name = "cmbxClientName";
			this.cmbxClientName.Size = new System.Drawing.Size(226, 24);
			this.cmbxClientName.TabIndex = 1;
			this.cmbxClientName.SelectionChangeCommitted += new System.EventHandler(this.cmbxClientName_SelectionChangeCommitted);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(41, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Quick Punch";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Select Client Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(355, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Select Client Project";
			// 
			// cmbxClientProject
			// 
			this.cmbxClientProject.Enabled = false;
			this.cmbxClientProject.FormattingEnabled = true;
			this.cmbxClientProject.Location = new System.Drawing.Point(358, 133);
			this.cmbxClientProject.Name = "cmbxClientProject";
			this.cmbxClientProject.Size = new System.Drawing.Size(233, 24);
			this.cmbxClientProject.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date";
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(69, 221);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(158, 22);
			this.txtDate.TabIndex = 7;
			// 
			// btnToday
			// 
			this.btnToday.Location = new System.Drawing.Point(253, 221);
			this.btnToday.Name = "btnToday";
			this.btnToday.Size = new System.Drawing.Size(75, 31);
			this.btnToday.TabIndex = 8;
			this.btnToday.Text = "Today";
			this.btnToday.UseVisualStyleBackColor = true;
			this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Time In";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(360, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Time Out";
			// 
			// txtTimeIn
			// 
			this.txtTimeIn.Location = new System.Drawing.Point(69, 333);
			this.txtTimeIn.Name = "txtTimeIn";
			this.txtTimeIn.Size = new System.Drawing.Size(158, 22);
			this.txtTimeIn.TabIndex = 11;
			// 
			// btnNowIn
			// 
			this.btnNowIn.Location = new System.Drawing.Point(253, 333);
			this.btnNowIn.Name = "btnNowIn";
			this.btnNowIn.Size = new System.Drawing.Size(75, 31);
			this.btnNowIn.TabIndex = 12;
			this.btnNowIn.Text = "Now";
			this.btnNowIn.UseVisualStyleBackColor = true;
			this.btnNowIn.Click += new System.EventHandler(this.btnNowIn_Click);
			// 
			// btnTimeOut
			// 
			this.btnTimeOut.Location = new System.Drawing.Point(536, 333);
			this.btnTimeOut.Name = "btnTimeOut";
			this.btnTimeOut.Size = new System.Drawing.Size(75, 31);
			this.btnTimeOut.TabIndex = 13;
			this.btnTimeOut.Text = "Now";
			this.btnTimeOut.UseVisualStyleBackColor = true;
			this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
			// 
			// txtTimeOut
			// 
			this.txtTimeOut.Location = new System.Drawing.Point(363, 333);
			this.txtTimeOut.Name = "txtTimeOut";
			this.txtTimeOut.Size = new System.Drawing.Size(158, 22);
			this.txtTimeOut.TabIndex = 14;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(351, 660);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(115, 45);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(78, 428);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(682, 226);
			this.txtNotes.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(75, 391);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Notes";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(72, 740);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "Current Punch: ";
			// 
			// lblCurrentPunch
			// 
			this.lblCurrentPunch.AutoSize = true;
			this.lblCurrentPunch.Location = new System.Drawing.Point(186, 740);
			this.lblCurrentPunch.Name = "lblCurrentPunch";
			this.lblCurrentPunch.Size = new System.Drawing.Size(240, 17);
			this.lblCurrentPunch.TabIndex = 19;
			this.lblCurrentPunch.Text = "There is no punch active at this time.";
			// 
			// btnEditCurrentPunch
			// 
			this.btnEditCurrentPunch.Location = new System.Drawing.Point(189, 774);
			this.btnEditCurrentPunch.Name = "btnEditCurrentPunch";
			this.btnEditCurrentPunch.Size = new System.Drawing.Size(163, 31);
			this.btnEditCurrentPunch.TabIndex = 20;
			this.btnEditCurrentPunch.Text = "Edit Current Punch";
			this.btnEditCurrentPunch.UseVisualStyleBackColor = true;
			this.btnEditCurrentPunch.Click += new System.EventHandler(this.btnEditCurrentPunch_Click);
			// 
			// TimeTracker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(796, 828);
			this.Controls.Add(this.btnEditCurrentPunch);
			this.Controls.Add(this.lblCurrentPunch);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtTimeOut);
			this.Controls.Add(this.btnTimeOut);
			this.Controls.Add(this.btnNowIn);
			this.Controls.Add(this.txtTimeIn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnToday);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbxClientProject);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbxClientName);
			this.Controls.Add(this.menuStrip1);
			this.MaximizeBox = false;
			this.Name = "TimeTracker";
			this.Text = "TimeTracker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewAllClientsToolStripMenuItem;
		private System.Windows.Forms.ComboBox cmbxClientName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbxClientProject;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Button btnToday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTimeIn;
		private System.Windows.Forms.Button btnNowIn;
		private System.Windows.Forms.Button btnTimeOut;
		private System.Windows.Forms.TextBox txtTimeOut;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCurrentPunch;
		private System.Windows.Forms.Button btnEditCurrentPunch;
		private System.Windows.Forms.ToolStripMenuItem addNewClientProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewAllProjectsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
	}
}

