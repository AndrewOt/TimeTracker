using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
	class DbConn
	{
		private static string CONNECTION_STRING = "Data Source= C:\\Users\\andre\\Programming\\C#\\TimeTracker\\TimeTracker\\TimeTracker\\TimeTrackerDB.db;Version=3;";

		public string connectStr {
			get
			{
				return CONNECTION_STRING;
			}
			set
			{
				string baseStr = CONNECTION_STRING.Split(' ')[0];
				CONNECTION_STRING = baseStr + value;
			}
		}
		

		public static SQLiteDataReader doQuery(string[] fields, string[] tables, params string[] conditions)
		{
			//Build Select string
			string sql = "SELECT ";
			for (int i = 0; i < fields.Length; i++)
			{
				sql += fields[i];
				sql += (i - 1) == fields.Length ? ", " : " ";
			}
			sql += "FROM ";
			if (tables.Length > 1)
			{
				
			}
			else
			{
				sql += tables[0];
			}

			try
			{
				SQLiteConnection m_dbConnection;
				m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
				m_dbConnection.Open();
				SQLiteCommand c = new SQLiteCommand("SELECT * FROM Client", m_dbConnection);
				SQLiteDataReader d = c.ExecuteReader();
				m_dbConnection.Close();
				return d;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.StackTrace);
				return null;
			}
		}

		public static int doQueryTest()
		{

			try
			{
				SQLiteConnection m_dbConnection;
				m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
				m_dbConnection.Open();
				SQLiteCommand c = new SQLiteCommand("SELECT * FROM Client", m_dbConnection);
				SQLiteDataReader d = c.ExecuteReader();
				m_dbConnection.Close();
				return 0;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.StackTrace);
				return 1;
			}
		}

		public static void doUpdateQuery(string Client, string Project, string Date, string TimeIn, string TimeOut, string Notes)
		{
			try
			{
				SQLiteConnection m_dbConnection;
				m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
				m_dbConnection.Open();
				SQLiteCommand c = new SQLiteCommand();
				c.CommandText = "";
				c.ExecuteNonQuery();
				m_dbConnection.Close();
			} catch (Exception e)
			{
				Debug.WriteLine(e.StackTrace);
			}
		}

	}
}
