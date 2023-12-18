using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.DataAccess
{
	public class MenuRepository : IMenuRepository
	{
		private readonly MenuDbContext _context;
		public MenuRepository(MenuDbContext context)
		{
			_context = context;
		}

		public async Task<Menu> GetByIdAsync(int id)
		{
			return await _context.Menus.FindAsync(id);
		}

		public async Task<IEnumerable<Menu>> GetAllAsync()
		{
			return await _context.Menus.ToListAsync();
		}

		public async Task AddAsync(Menu entity)
		{
			_context.Menus.Add(entity);
			await _context.SaveChangesAsync();
		}
	}
}
