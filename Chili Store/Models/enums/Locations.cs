using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Chili_Store.Models
{
	public enum Locations
	{
		[Display(Name = "Taos")]
		Taos = 1,

		[Display(Name = "Santa Fe")]
		SantaFE = 2,

		[Display(Name = "Alamogordo")]
		Alamogordo = 3,
		
		[Display(Name = "Silver City")]
		SilverCity = 4
	}
}
