using FastEndpoints;
using Menu.DataAccess;

namespace Menu.API.Endpoints.AddNew
{
	public class Handler(IMenuRepository repository) : Endpoint<Request,Response>
	{
		public override void Configure()
		{
			Post("/");
			AllowAnonymous();
		}

		//public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
		//{
		//	if (request.Data is null)
		//	{
		//		await SendAsync(new Response("Fail", false, null), 400, CancellationToken.None);
		//		return;
		//	}
		//}


	}
}
