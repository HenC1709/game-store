namespace GameStore.Application.Features.Catalog;

public class ProductService(IProductRepository repository)
{
    public async Task<IReadOnlyList<ProductDto>> GetAllAsync(ProductFilter filter)
    {
        var products = await repository.GetAllAsync(filter);

        return products
            .Select(p => new ProductDto(p.Id, p.Name, p.Platform, p.Price, p.ImageUrl, p.Stock > 0))
            .ToList();
    }

    // Devuelve null si el producto no existe; el controlador lo convierte en 404.
    public async Task<ProductDetailDto?> GetByIdAsync(int id)
    {
        var p = await repository.GetByIdAsync(id);

        return p is null
            ? null
            : new ProductDetailDto(p.Id, p.Name, p.Description, p.Platform, p.Genre, p.Price, p.ImageUrl, p.Stock > 0);
    }
}
