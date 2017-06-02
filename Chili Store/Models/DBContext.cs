using Chili_Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Chili_Store { 
		public class ApplicationDbContexts : DbContext
		{
		public ApplicationDbContexts()
			: base("DefaultConnection")
		{
		}

		public static ApplicationDbContexts Create()
		{
			return new ApplicationDbContexts();
		}
		public virtual  DbSet<Chili> chili { get; set; }
	}
}