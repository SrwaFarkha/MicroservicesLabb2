using Domain.Common.DTOs;

namespace Menu.API.Endpoints.GetAll
{
	public class Response
	{
		public IEnumerable<MenuDto> Menus { get; set; } = new List<MenuDto>();

	}
}
