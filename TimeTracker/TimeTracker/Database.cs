using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TimeTracker
{
	class DbConn
	{
		/// <summary>
		/// The connection string to the SQLite Database. Is changeable via the settings window. Is loaded at launch from config.xml.
		/// </summary>
		private static string CONNECTION_STRING = "Data Source= C:\\Users\\andre\\Programming\\C#\\TimeTracker\\TimeTracker\\TimeTracker\\TimeTrackerDB.db;Version=3;";

		public string connectStr {
			get
			{
				return CONNECTION_STRING;
			}
			set
			{
				//TODO: add test to see if db actually exists
				string baseStr = CONNECTION_STRING.Split(' ')[0];
				CONNECTION_STRING = baseStr + value;
			}
		}

		/// <summary>
		/// Querys the SQLite Database.
		/// </summary>
		/// <param name="fields"></param>
		/// <param name="table"></param>
		/// <param name="conditions"></param>
		/// <returns></returns>
		public static DataTable doQuery(string[] fields, string table, string[] conditions = null, string[] order = null)
		{
			//Build Select string
			string sql = "SELECT ";
			for (int i = 0; i < fields.Length; i++)
			{
				sql += fields[i];
				sql += i != fields.Length - 1 ? ", " : " ";
			}

			sql += "FROM ";
			sql += table;

			if (conditions != null)
			{
				if (conditions.Length > 0)
				{
					sql += " WHERE ";
					for (int k = 0; k < conditions.Length; k++)
					{
						sql += conditions[k];
						sql += k != conditions.Length - 1 ? ", " : " ";
					}
				} 
			}
			if (order != null)
			{
				if (order.Length > 0)
				{
					sql += " ORDER BY ";
					for (int m = 0; m < order.Length; m++)
					{
						sql += order[m];
						sql += m != order.Length - 1 ? ", " : " ";
					}
				} 
			}
			Debug.WriteLine(sql);

			//Run Query and return results
			try
			{
				SQLiteConnection m_dbConnection;
				m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
				m_dbConnection.Open();
				SQLiteDataAdapter a = new SQLiteDataAdapter(sql, m_dbConnection);
				DataTable d = new DataTable();
				a.Fill(d);
				m_dbConnection.Close();
				return d;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.StackTrace);
				return new DataTable();
			}
		}

		//public static DataTable doQuery(string[] fields, string[] tables, string[] order = null, string[] conditions = null)
		//{
		//	//Build Select string
		//	string sql = "SELECT ";
		//	for (int i = 0; i < fields.Length; i++)
		//	{
		//		sql += fields[i];
		//		sql += i != fields.Length - 1 ? ", " : " ";
		//	}
		//	sql += "FROM ";
		//	if (tables.Length > 1)
		//	{
		//		for (int j = 0; j < tables.Length; j++)
		//		{
		//			sql += tables[j];
		//			sql += j != tables.Length - 1 ? ", " : " ";
		//		}
		//	}
		//	else
		//	{
		//		sql += tables[0];
		//	}
		//	if (conditions.Length > 0)
		//	{
		//		sql += " WHERE ";
		//		for (int k = 0; k < conditions.Length; k++)
		//		{
		//			sql += conditions[k];
		//			sql += k != conditions.Length - 1 ? ", " : " ";
		//		}
		//	}
		//	
		//	Debug.WriteLine(sql);

		//	//Run Query and return results.
		//	try
		//	{
		//		SQLiteConnection m_dbConnection;
		//		m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
		//		m_dbConnection.Open();
		//		SQLiteDataAdapter a = new SQLiteDataAdapter(sql, m_dbConnection);
		//		DataTable d = new DataTable();
		//		a.Fill(d);
		//		m_dbConnection.Close();
		//		return d;
		//	}
		//	catch (Exception e)
		//	{
		//		Debug.WriteLine(e.StackTrace);
		//		return new DataTable();
		//	}
		//}

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
