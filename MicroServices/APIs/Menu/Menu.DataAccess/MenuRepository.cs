using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.DataAccess
{
	public class MenuRepository(MenuDbContext context) : IMenuRepository
	{
		public async Task<Menu> GetByIdAsync(int id)
		{
			return await context.Menus.FindAsync(id)  ?? throw new InvalidOperationException();
		}

		public async Task<IEnumerable<Menu>> GetAllAsync()
		{
			return await context.Menus.ToListAsync();
		}

		public async Task AddAsync(Menu entity)
		{
			context.Menus.Add(entity);
			await context.SaveChangesAsync();
		}
	}
}
