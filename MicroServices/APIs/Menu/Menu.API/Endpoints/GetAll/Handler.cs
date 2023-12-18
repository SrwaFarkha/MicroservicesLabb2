using System.Runtime.InteropServices.ComTypes;
using Domain.Common.DTOs;
using FastEndpoints;
using Menu.DataAccess;

namespace Menu.API.Endpoints.GetAll
{
	public class Handler(IMenuRepository repository) : Endpoint<Request,Response>
	{
		public override void Configure()
		{
			Get("/");
			AllowAnonymous();
		}

		public override async Task HandleAsync(Request req, CancellationToken ct)
		{
			var allMenu = await repository.GetAllAsync();
			var menuDtos =
				allMenu.Select(x => 
					new MenuDto(
						x.Name,
						x.Ingredients,
						x.Price
						)
				);
			await SendAsync(
				new Response()
				{
					Menus = menuDtos
				},
				cancellation: ct);
		}
	}
}
