using GameStore.Application.Features.Catalog;
using GameStore.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Cuando haya base de datos, cambiar esta línea por ProductRepository.
        services.AddSingleton<IProductRepository, InMemoryProductRepository>();
        return services;
    }
}