using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
	public partial class TimeTracker : Form
	{
		public TimeTracker()
		{
			InitializeComponent();
			PopulateClients();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void clientToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void viewAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void btnEditCurrentPunch_Click(object sender, EventArgs e)
		{
			TestingForm t = new TestingForm();
			t.Show();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string Client = cmbxClientName.Text;
			string Project = cmbxClientProject.Text;
			string TimeIn = txtTimeIn.Text;
			string TimeOut = txtTimeOut.Text;
			string Notes = txtNotes.Text;
			string Date = txtDate.Text;
			//DialogResult r;
			//r = MessageBox.Show(DbConn.doQueryTest().ToString(), "Success!", MessageBoxButtons.YesNo);
			//TestingForm tf = new TestingForm();
			//tf.
			//tf.Load += fill;
			//DbConn.doUpdateQuery();
		}

		private void fill(object sender, EventArgs e)
		{

		}

		private void cmbxClientName_SelectedIndexChanged(object sender, EventArgs e)
		{
			string clientName = cmbxClientName.SelectedText;
			//DbConn.doUpdateQuery();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings s = new Settings();
			s.Show(this);
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			txtDate.Text = DateTime.Now.ToString().Split(' ')[0];
		}

		private void btnNowIn_Click(object sender, EventArgs e)
		{
			txtTimeIn.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		private void btnTimeOut_Click(object sender, EventArgs e)
		{
			txtTimeOut.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		/*
		 * Credit: http://stackoverflow.com/questions/256832/c-sharp-fill-a-combo-box-with-a-datatable
		 * http://stackoverflow.com/questions/17538323/how-to-display-two-different-columns-in-one-combobox
		 */
		private void PopulateClients()
		{
			//Get data
			string[] fields = { "ID", "FullName" };
			string[] table = { "ClientContact" };
			DataTable dt = DbConn.doQuery(fields, table);
			cmbxClientName.DataSource = dt;
			cmbxClientName.DisplayMember = "FullName";
			cmbxClientName.ValueMember = "ID";
			cmbxClientName.Text = "";
		}
	}
}
