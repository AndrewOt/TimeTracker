﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
	class Project
	{
		public int ID {get; set;}
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreateionDate { get; set; }
		public string Notes { get; set; }
		public Client Client { get; set; }
		public Punch[] punches { get; set; }

	}
}
