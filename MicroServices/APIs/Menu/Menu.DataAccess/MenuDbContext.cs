using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Menu.DataAccess
{
	public class MenuDbContext: DbContext
	{
		public virtual DbSet<Menu> Menus { get; set; } = null!;
		public MenuDbContext(DbContextOptions<MenuDbContext> options)
			: base(options)
		{
			try
			{
				if (Database.GetService<IDatabaseCreator>() is RelationalDatabaseCreator databaseCreator)
				{
					if (!databaseCreator.CanConnect()) databaseCreator.Create();
					if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
