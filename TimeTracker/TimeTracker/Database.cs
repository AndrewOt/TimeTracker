using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
	class DbConn
	{
		public static SQLiteDataReader doQuery()
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\andre\\Programming\\C#\\TimeTracker\\TimeTracker\\TimeTracker\\TimeTrackerDB.db;Version=3;");
			m_dbConnection.Open();
			SQLiteCommand c = new SQLiteCommand("SELECT * FROM Client", m_dbConnection);
			SQLiteDataReader d = c.ExecuteReader();
			m_dbConnection.Close();
			return d;
		}

		public static void doUpdateQuery()
		{
			SQLiteConnection m_dbConnection;
			m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
			m_dbConnection.Open();
		}

	}
}
