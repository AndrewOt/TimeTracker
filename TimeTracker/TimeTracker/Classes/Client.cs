using System;
using System.Collections.Generic;
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
		public string Address { get; set; }
		public string PrimaryPhoneNum { get; set; }
		public string SecondaryPhoneNum { get; set; }
		public string Email { get; set; }
		public string Notes { get; set; }

		public Client() { }

		public Client(int ID)
		{
			this.ID = ID;
		}

		public void CreateClient()
		{

		}

	}
}
