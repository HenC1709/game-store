namespace GameStore.Application.Features.Catalog;

public class ProductService(IProductRepository repository)
{
    public async Task<IReadOnlyList<ProductDto>> GetAllAsync()
    {
        var products = await repository.GetAllAsync();

        return products
            .Select(p => new ProductDto(p.Id, p.Name, p.Platform, p.Price, p.ImageUrl, p.Stock > 0))
            .ToList();
    }
}