using Domain.Common.DTOs;

namespace Menu.API.Endpoints.AddNew
{
	public readonly struct Response(string message, bool success, MenuDto? data)
	{
		public string Message { get; } = message;
		public bool Success { get; } = success;
		public MenuDto? Data { get; } = data;
	}
}
