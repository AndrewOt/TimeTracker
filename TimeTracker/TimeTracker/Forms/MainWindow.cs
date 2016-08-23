using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace TimeTracker
{
	public partial class TimeTracker : Form
	{

		bool InputIsNumber;
		private int CurrentPunchID;

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
			string TimeIn = txtTimeIn.Text;
			string TimeOut = txtTimeOut.Text;
			string Notes = txtNotes.Text;
			string Date = txtDateIn.Text;
			string[] values = { cmbxClientProject.SelectedValue.ToString(), txtTimeIn.Text, txtTimeOut.Text, Notes, Date };
			string[] columns = { "ClientProjectIDFK", "TimeIn", "TimeOUt", "Notes", "DatePunched" };
			string table = "TimePunch";
			DbConn.doInsert(values, table, columns);
			MessageBox.Show("The punch was successfully added!", "Punch successful");
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
			txtDateIn.Text = DateTime.Now.ToString().Split(' ')[0];
		}

		private void btnNowIn_Click(object sender, EventArgs e)
		{
			txtTimeIn.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		private void btnTimeOut_Click(object sender, EventArgs e)
		{
			txtTimeOut.Text = DateTime.Now.ToString().Split(' ')[1];
		}

		private void btnDateOutToday_Click(object sender, EventArgs e)
		{
			txtDateOut.Text = DateTime.Now.ToString().Split(' ')[0];
		}

		private void cmbxClientName_SelectionChangeCommitted(object sender, EventArgs e)
		{
			DataRowView SelectedClientRow = (DataRowView)cmbxClientName.SelectedItem;
			int ID = int.Parse(SelectedClientRow.Row[0].ToString());
			if (ID != 0)
				PopulateClientProjects(ID);
			else
				cmbxClientProject.Enabled = false;
		}

		/// <summary>
		/// Populates the Form on application launch.
		/// </summary>
		private void PopulateForm()
		{
			PopulateClients();
			string[] field = { "*" };
			string table = "TimePunch";
			string[] conditions = { "TimeOut IS NULL OR TimeOut=''" };
			DataTable punch = DbConn.doQuery(field, table, conditions);
			if (punch.Rows.Count != 0)
			{
				CurrentPunchID = int.Parse(punch.Rows[0][0].ToString());
				int ClientId;
				cmbxClientName.SelectedValue = int.Parse(GetClientNameFromPunch(punch));
				cmbxClientProject.Enabled = true;
				bool parse = int.TryParse(cmbxClientName.SelectedValue.ToString(), out ClientId);
				PopulateClientProjects(ClientId);
				cmbxClientProject.SelectedValue = int.Parse(punch.Rows[0][1].ToString());
				txtTimeIn.Text = punch.Rows[0][2].ToString();
				txtTimeOut.Text = punch.Rows[0][3].ToString();
				txtDateIn.Text = punch.Rows[0][5].ToString();
				txtNotes.Text = punch.Rows[0][4].ToString();
				lblCurrentPunch.Text = "--- Punched In: " + punch.Rows[0][2].ToString() + ", Date In: " 
					+ punch.Rows[0][6].ToString() + ", Client: " + cmbxClientName.Text + " ---";
			}
		}

		private void PopulateClientProjects(int ClientID)
		{
			cmbxClientProject.Enabled = true;
			string[] fields = { "Title", "ID" };
			string table = "ClientProject";
			string[] ProjectConditions = { "ClientIDFK=" + ClientID.ToString() };
			DataTable ProjectList = DbConn.doQuery(fields, table, ProjectConditions);

			//Fill dropdown
			cmbxClientProject.DataSource = ProjectList;
			cmbxClientProject.DisplayMember = "Title";
			cmbxClientProject.ValueMember = "ID";
		}

		//Think about restructing this to be more effecient.
		/// <summary>
		/// 
		/// </summary>
		/// <param name="punch" type="DataTable"></param>
		/// <returns>The ID of the Client.</returns>
		private string GetClientNameFromPunch(DataTable punch)
		{
			string[] ProjectConditions = { "ID=" + punch.Rows[0][1].ToString() };
			string ClientTable = "ClientProject";
			string[] field = { "*" };
			DataTable project = DbConn.doQuery(field, ClientTable, ProjectConditions);
			return project.Rows[0][1].ToString();
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

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtTimeIn.Text = "";
			txtTimeOut.Text = "";
			txtDateIn.Text = "";
			txtDateOut.Text = "";
			txtNotes.Text = "";
			cmbxClientName.SelectedIndex = 0;
			cmbxClientProject.Enabled = false;
		}

		private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (InputIsNumber)
			{
				e.Handled = true;
			}
		}

		private void txtDate_KeyDown(object sender, KeyEventArgs e)
		{
			InputIsNumber = false;
			if (e.KeyCode <= Keys.D0 || e.KeyCode >= Keys.D9)
			{
				if (e.KeyCode <= Keys.NumPad0 || e.KeyCode >= Keys.NumPad9)
				{
					if (e.KeyCode != Keys.Back)
					{
						if (e.KeyCode == Keys.Divide)
						InputIsNumber = true;
					}
				}
			}
		}

	}
}