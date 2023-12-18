using Domain.Common.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.DataAccess
{
	public class Menu : IEntity<int>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<string> Ingredients { get; set; }
		public decimal Price { get; set; }
	}
}
