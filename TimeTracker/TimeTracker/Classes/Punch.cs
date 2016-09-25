using System;
using System.Data;
using System.Windows.Forms;

namespace TimeTracker.Classes
{
	/// <summary>
	/// This class represents a time punch from the database.
	/// It get its data from the TimePunch table.
	/// </summary>
	class Punch
	{
		public int ID { get; set; }
		public string TimeIn { get; set; }
		public string TimeOut { get; set; }
		public string DateIn { get; set; }
		public string DateOut { get; set; }
		public string Notes { get; set; }
		public bool IsEmpty { get; set; }
		public Project project { get; set; }

		/// <summary>
		/// The default constructor pulls the top unpunched time punch.
		/// </summary>
		public Punch()
		{
			string[] field = { "*" };
			string table = "TimePunch";
			string[] conditions = { "TimeOut IS NULL OR TimeOut=''" };
			DataTable punch = DbConn.doQuery(field, table, conditions);
			if (punch != null)
			{
				BuildPunchObject(punch);
				IsEmpty = false;
			}
			else
				IsEmpty = true;
		}

		public Punch(int ID)
		{
			this.ID = ID;
			GetPunchFromId();
		}

		private void GetPunchFromId()
		{
			if (ID != -1)
			{
				string table = "TimePunch";
				string[] fields = { "*" };
				string[] conditions = { "ID=" + ID };
				DataTable ThisPunch = DbConn.doQuery(fields, table, conditions);
				BuildPunchObject(ThisPunch);
				IsEmpty = false;
			}
			else
			{
				IsEmpty = true;
				throw new Exception("No ID set!");
			}
		}

		private void BuildPunchObject(DataTable RawData)
		{
			TimeIn = RawData.Rows[0][2].ToString();
			TimeOut = RawData.Rows[0][3].ToString();
			Notes = RawData.Rows[0][4].ToString();
			DateIn = RawData.Rows[0][5].ToString();
			DateOut = RawData.Rows[0][6].ToString();
			//client = new Client(ID);
		}

		/// <summary>
		/// This function checks to see if there exists a punch in the table that has not been punched out. If there is the 
		/// case of several punches that haven't been punched out, then this function will only take the top result.
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		public static bool IsActivePunch(out Punch p)
		{
			string[] fields = { "*" };
			string table = "TimePunch";
			string[] conditions = { "DatePunchedOut=NULL OR TimeOut IS NULL OR TimeOut=''" };
			int limit = 1;
			DataTable dt = DbConn.doQuery(fields, table, conditions, null, limit);
			int i = 0;
			if (int.TryParse(dt.Rows[0]["ID"].ToString(), out i))
			{
				p = new Punch(int.Parse(dt.Rows[0]["ID"].ToString()));
				return true;
			}
			else
			{
				p = null;
				return false;
			}
		}

		/// <summary>
		/// Updates the punch in the database to match the values of this object.
		/// </summary>
		public void CommitUpdatePunch()
		{

		}

		public void CommitSavePunch()
		{

		}

	}
}
