namespace TimeTracker
{
	partial class Saving
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
			this.lblInfo = new System.Windows.Forms.Label();
			this.progSave = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.lblInfo.Location = new System.Drawing.Point(97, 43);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(337, 29);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "Please wait while saving...";
			// 
			// progSave
			// 
			this.progSave.Location = new System.Drawing.Point(63, 111);
			this.progSave.Name = "progSave";
			this.progSave.Size = new System.Drawing.Size(421, 23);
			this.progSave.TabIndex = 1;

			// 
			// Saving
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 216);
			this.Controls.Add(this.progSave);
			this.Controls.Add(this.lblInfo);
			this.Name = "Saving";
			this.Text = "Saving";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ProgressBar progSave;
	}
}