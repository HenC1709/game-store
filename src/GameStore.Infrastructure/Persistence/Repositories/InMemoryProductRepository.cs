using GameStore.Application.Features.Catalog;
using GameStore.Domain.Entities;

namespace GameStore.Infrastructure.Persistence.Repositories;

// Temporal para el MVP 0. Se reemplaza por ProductRepository (EF Core) cuando haya base de datos.
public class InMemoryProductRepository : IProductRepository
{
    private static readonly List<Product> Products =
    [
        new() { Id = 1, Name = "Elden Ring", Description = "RPG de mundo abierto.", Platform = "PS5", Genre = "RPG", Price = 59.99m, Stock = 12, ImageUrl = "https://placehold.co/300x400?text=Elden+Ring" },
        new() { Id = 2, Name = "Zelda: Tears of the Kingdom", Description = "Aventura en Hyrule.", Platform = "Switch", Genre = "Aventura", Price = 69.99m, Stock = 0, ImageUrl = "https://placehold.co/300x400?text=Zelda" },
        new() { Id = 3, Name = "Forza Horizon 5", Description = "Carreras en México.", Platform = "Xbox", Genre = "Carreras", Price = 49.99m, Stock = 8, ImageUrl = "https://placehold.co/300x400?text=Forza" },
        new() { Id = 4, Name = "Hades", Description = "Roguelike de acción.", Platform = "PC", Genre = "Roguelike", Price = 24.99m, Stock = 20, ImageUrl = "https://placehold.co/300x400?text=Hades" },
        new() { Id = 5, Name = "FC 26", Description = "Fútbol.", Platform = "PS5", Genre = "Deportes", Price = 59.99m, Stock = 5, ImageUrl = "https://placehold.co/300x400?text=FC+26" },
        new() { Id = 6, Name = "Stardew Valley", Description = "Simulador de granja.", Platform = "PC", Genre = "Simulación", Price = 14.99m, Stock = 30, ImageUrl = "https://placehold.co/300x400?text=Stardew" },
    ];

    public Task<IReadOnlyList<Product>> GetAllAsync() =>
        Task.FromResult<IReadOnlyList<Product>>(Products);
}