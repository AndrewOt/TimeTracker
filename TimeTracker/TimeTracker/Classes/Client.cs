using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
	class Client
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string FullName { get; set; }
		public string PrimaryPhoneNum { get; set; }
		public string SecondaryPhoneNum { get; set; }
		public string Email { get; set; }
		public string Notes { get; set; }
		public bool IsEmpty { get; set; }
		public Project[] projects { get; set; }


		public Client()
		{
			IsEmpty = true;
		}

		public Client(int ID)
		{
			this.ID = ID;
			BuildClient();
			IsEmpty = false;
		}

		public void BuildClient()
		{
			string[] field = { "*" };
			string table = "ClientContact";
			string[] conditions = { "ID=" + ID };
			DataTable ThisClient = DbConn.doQuery(field, table, conditions);
			Title = ThisClient.Rows[0]["Title"].ToString();
			FName = ThisClient.Rows[0]["FName"].ToString();
			LName = ThisClient.Rows[0]["LName"].ToString();
			FullName = ThisClient.Rows[0]["FullName"].ToString();
			PrimaryPhoneNum = ThisClient.Rows[0]["PrimaryPhone"].ToString();
			SecondaryPhoneNum = ThisClient.Rows[0]["SecondaryPhone"].ToString();
			Email = ThisClient.Rows[0]["Email"].ToString();
			Notes = ThisClient.Rows[0]["Notes"].ToString();
		}

	}
}
