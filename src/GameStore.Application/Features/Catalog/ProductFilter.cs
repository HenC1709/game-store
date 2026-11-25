namespace GameStore.Application.Features.Catalog;

// Filtros opcionales de la lista de productos. Un valor null significa "no filtrar por esto".
public record ProductFilter(string? Search = null, string? Platform = null, string? Genre = null, decimal? MaxPrice = null);
