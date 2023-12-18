using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Menu.DataAccess
{
	public class MenuDbContext: DbContext
	{
		public MenuDbContext(DbContextOptions<MenuDbContext> options)
			: base(options)
		{
		}

		public DbSet<Menu> Menus { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure your entity mappings if needed
		}
	}
}
