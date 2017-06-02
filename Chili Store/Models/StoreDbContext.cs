using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Chili_Store.Models
{
	public class StoreDbContext: DbContext
	{
		public StoreDbContext()
			: base("DefaultConnection")
		{
		}

		public static StoreDbContext Create()
		{
			return new StoreDbContext();
		}

		public virtual DbSet<Chili> Chili { get; set; }
	}
}