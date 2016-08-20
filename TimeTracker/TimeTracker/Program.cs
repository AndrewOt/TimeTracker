using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TimeTracker());
			Initialize();
		}

		private static void Initialize()
		{
			//Get settings from config.xml


			//Load Clients into drop down list
			string[] fields = { "FName", "LName" };
			string[] table = { "ClientContact" };
			DbConn.doQuery(fields, table);
		}
	}
}
