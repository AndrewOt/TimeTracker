namespace TimeTracker
{
	partial class Form1
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
			this.viewAllClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
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
			this.menuStrip1.Size = new System.Drawing.Size(1697, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clientToolStripMenuItem
			// 
			this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.viewAllClientsToolStripMenuItem});
			this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
			this.clientToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.clientToolStripMenuItem.Text = "Client";
			this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
			// 
			// addNewToolStripMenuItem
			// 
			this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
			this.addNewToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
			this.addNewToolStripMenuItem.Text = "Add New";
			// 
			// viewAllClientsToolStripMenuItem
			// 
			this.viewAllClientsToolStripMenuItem.Name = "viewAllClientsToolStripMenuItem";
			this.viewAllClientsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
			this.viewAllClientsToolStripMenuItem.Text = "View All Clients";
			this.viewAllClientsToolStripMenuItem.Click += new System.EventHandler(this.viewAllClientsToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(526, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1697, 795);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.Button button1;
	}
}

