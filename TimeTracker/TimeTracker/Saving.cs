using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
	public partial class Saving : Form
	{
		public Saving()
		{
			InitializeComponent();
		}

		public void SetProgress(int progress)
		{
			progSave.Increment(progress);
		}

		//private void progSave_Click(object sender, ProgressChangedEventArgs e)
		//{
		//	if (progSave.Maximum == e.ProgressPercentage)
		//	{
		//		Dispose();
		//	}
		//}
	}
}
