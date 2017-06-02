using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chili_Store.Models
{
	public class Chili
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string Region { get; set; }
		public string HeatLevel { get; set; }
		public int weight { get; set; }
	}
}