using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TimeTracker
{
	public partial class TestingForm : Form
	{
		public TestingForm()
		{
			InitializeComponent();
			string[] fields = { "FName", "LName" };
			string[] table = { "ClientContact" };
			DataTable dt = DbConn.doQuery(fields, table);
			dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
			dataGridView1.DataSource = dt;
			
		}
	}
}
