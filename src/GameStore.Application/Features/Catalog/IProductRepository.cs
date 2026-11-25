using GameStore.Domain.Entities;

namespace GameStore.Application.Features.Catalog;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetAllAsync(ProductFilter filter);
    Task<Product?> GetByIdAsync(int id);
}
