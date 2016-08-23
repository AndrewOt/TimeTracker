using System;
using System.Data;

namespace TimeTracker.Classes
{
	/// <summary>
	/// This class represents a time punch from the database.
	/// It get its data from the TimePunch table.
	/// </summary>
	class Punch
	{
		private int _ID = -1;
		public int ID { get; set; }
		public string TimeIn { get; set; }
		public string TimeOut { get; set; }
		public string DateIn { get; set; }
		public string DateOut { get; set; }
		public string Notes { get; set; }

		/// <summary>
		/// The default constructor pulls the top unpunched time punch.
		/// </summary>
		public Punch()
		{
			string[] field = { "TOP 1 *" };
			string table = "TimePunch";
			string[] conditions = { "TimeOut IS NULL OR TimeOut=''" };
			DataTable punch = DbConn.doQuery(field, table, conditions);
			if (punch != null)
				BuildPunchObject(punch);
		}

		public Punch(int ID)
		{
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
			}
			else
			{
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
		}

	}
}
