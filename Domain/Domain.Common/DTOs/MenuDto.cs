namespace Domain.Common.DTOs;

public record MenuDto(string Name, List<string> Ingredients, decimal Price);