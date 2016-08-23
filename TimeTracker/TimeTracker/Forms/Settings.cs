using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TimeTracker
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dbConnectStringDialog = new OpenFileDialog();
			dbConnectStringDialog.InitialDirectory = "c:\\";
			dbConnectStringDialog.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
			dbConnectStringDialog.FilterIndex = 0;
			dbConnectStringDialog.RestoreDirectory = true;

			if(dbConnectStringDialog.ShowDialog() == DialogResult.OK)
			{
				txtConnectStr.Text = dbConnectStringDialog.FileName;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			//Show saving form
			Saving save = new Saving();
			save.Show();
			//Save settings to config.xml
			using (XmlWriter writer = XmlWriter.Create("test.xml"))
			{
				
				writer.WriteStartDocument();
				writer.WriteComment("\nThis is the configuration file for TimeTrack.exe. DO NOT change this file\n" +
					" with a text editor. Please use the settings options in the gui. That is unless you want\n" +
					" your program broken!");
				writer.WriteRaw("\n");

				writer.WriteStartElement("testing");
				writer.WriteRaw("\n\t");
				writer.WriteElementString("TestElement1", "hello there");
				writer.WriteString("\n\t");
				writer.WriteElementString("TestElement2", "hello there2");
				writer.WriteString("\n\t");
				writer.WriteElementString("TestElement3", "hello there3");
				writer.WriteString("\n");

				writer.WriteEndElement();
				writer.WriteEndDocument();
			}

		}
	}
}
