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
			PopulateForm();
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

		/*
		 * Credit: http://stackoverflow.com/questions/3263240/stop-comboboxs-selectedindexchanged-event-from-firing-when-the-form-loads
		 */
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings s = new Settings();
			s.Show();
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			txtDate.Text = DateTime.Now.ToString().Split(' ')[0];
		}

		private void cmbxClientName_SelectionChangeCommitted(object sender, EventArgs e)
		{
			DataRowView SelectedClientRow = (DataRowView)cmbxClientName.SelectedItem;
			PopulateClientProjects(int.Parse(SelectedClientRow.Row[0].ToString()));
		}

		private void btnNowIn_Click(object sender, EventArgs e)
		{
			txtTimeIn.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		private void btnTimeOut_Click(object sender, EventArgs e)
		{
			txtTimeOut.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		/// <summary>
		/// Populates the Form on application launch.
		/// </summary>
		private void PopulateForm()
		{
			PopulateClients();
			//cmbxClientName.Text = "";
			string[] field = { "*" };
			string table = "TimePunch";
			string[] conditions = { "TimeOut IS NULL" };
			DataTable punch = DbConn.doQuery(field, table, conditions);
			if (punch.Rows.Count != 0)
			{
				string NameID = GetClientNameFromPunch(punch);
				cmbxClientName.SelectedIndex = int.Parse(NameID);
				cmbxClientProject.Enabled = true;
				PopulateClientProjects(0);
				cmbxClientProject.SelectedIndex = 0;
				txtTimeIn.Text = punch.Columns["TimeIn"].ToString();
				txtDate.Text = punch.Columns["DatePunched"].ToString();
				txtNotes.Text = punch.Columns["Notes"].ToString();
			}
		}

		private void PopulateClientProjects(int ClientID)
		{
			cmbxClientProject.Enabled = true;
			string[] fields = { "Title", "ID" };
			string table = "ClientProject";
			string[] ProjectConditions = { "ClientIDFK=" + ClientID.ToString() };
			DataTable ProjectList = DbConn.doQuery(fields, table, ProjectConditions);

			//Add an empty row so that the first row will be empty and the text will show empty.
			DataRow EmptyRow = ProjectList.NewRow();
			EmptyRow["ID"] = 0;
			EmptyRow["Title"] = "";
			ProjectList.Rows.InsertAt(EmptyRow, 0);

			//Fill dropdown
			cmbxClientProject.DataSource = ProjectList;
			cmbxClientProject.DisplayMember = "Title";
			cmbxClientProject.ValueMember = "ID";
		}

		//Think about restructing this to be more effecient.
		private string GetClientNameFromPunch(DataTable punch)
		{
			string[] ProjectConditions = { "ClientProjectIDFK=" + punch.Columns["ClientProjectIDFK"].ToString() };
			string ClientTable = "ClientProject";
			string[] field = { "*" };
			DataTable project = DbConn.doQuery(field, ClientTable, ProjectConditions);
			if (project.Rows.Count > 0)
			{
				string[] ContactConditions = { "CliendIDFK=" + project.Columns["ClientIDFK"].ToString() };
				string ContactTable = "ClientContact";
				DataTable contact = DbConn.doQuery(field, ContactTable, ContactConditions);
				return contact.Columns["ID"].ToString();
			}
			else
			{
				return "0";
			}
		}

		/*
		 * Credit: http://stackoverflow.com/questions/256832/c-sharp-fill-a-combo-box-with-a-datatable
		 * http://stackoverflow.com/questions/17538323/how-to-display-two-different-columns-in-one-combobox
		 * http://stackoverflow.com/questions/337797/adding-new-row-to-datatables-top
		 */
		private void PopulateClients()
		{
			//Get data
			string[] fields = { "ID", "FullName" };
			string table = "ClientContact";
			DataTable ClientList = DbConn.doQuery(fields, table);

			//Add an empty row so that the first row will be empty and the text will show empty.
			DataRow EmptyRow = ClientList.NewRow();
			EmptyRow["ID"] = 0;
			EmptyRow["FullName"] = "";
			ClientList.Rows.InsertAt(EmptyRow, 0);

			//Populate combobox with database data
			cmbxClientName.DataSource = ClientList;
			cmbxClientName.DisplayMember = "FullName";
			cmbxClientName.ValueMember = "ID";
		}
	}
}
