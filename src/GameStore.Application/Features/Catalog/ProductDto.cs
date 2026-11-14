namespace GameStore.Application.Features.Catalog;

public record ProductDto(int Id, string Name, string Platform, decimal Price, string ImageUrl, bool InStock);