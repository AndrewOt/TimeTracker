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
			//TODO: Add parameterization to this function by using a SQLiteCommand object.
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

		public static void doInsert(string[] values, string table, string[] columns)
		{
			if (values.Length != columns.Length)
			{
				throw new Exception("Values and columns not equal length!");
			}
			SQLiteConnection m_dbConnection = new SQLiteConnection(CONNECTION_STRING);
			SQLiteCommand command = new SQLiteCommand();
			command.Connection = m_dbConnection;
			string sql = "INSERT INTO " + table;
			if (columns != null)
			{
				if (columns.Length > 0)
				{
					sql += " (";
					for(int i = 0; i < columns.Length; i++)
					{
						sql += columns[i];
						sql += i != columns.Length - 1 ? ", " : "";
					}
					sql += ") ";
				}
			}

			sql += " VALUES(";
			for (int j = 0; j < values.Length; j++)
			{
				//Build the rest of sql string. Uses parameterized values
				sql += j != values.Length - 1 ? "@" + columns[j] + ", " : "@" + columns[j];
				//Add parameterization to command object
				command.Parameters.AddWithValue("@" + columns[j], values[j]);
			}
			sql += ");";
			command.CommandText = sql;
			m_dbConnection.Open();
			command.ExecuteNonQuery();
			m_dbConnection.Close();
			Debug.WriteLine(sql);
		}

	}
}
