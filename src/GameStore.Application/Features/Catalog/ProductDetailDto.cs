namespace GameStore.Application.Features.Catalog;

public record ProductDetailDto(
    int Id,
    string Name,
    string Description,
    string Platform,
    string Genre,
    decimal Price,
    string ImageUrl,
    bool InStock);
