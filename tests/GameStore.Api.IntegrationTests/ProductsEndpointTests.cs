using System.Net;
using System.Net.Http.Json;
using GameStore.Application.Features.Catalog;
using Microsoft.AspNetCore.Mvc.Testing;

namespace GameStore.Api.IntegrationTests;

// Estos tests levantan la API en memoria y le hacen peticiones HTTP reales.
// Usan los 6 juegos de InMemoryProductRepository; si cambian esos datos, hay que ajustar los tests.
public class ProductsEndpointTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetAll_WithoutFilters_ReturnsAllProducts()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products");

        Assert.NotNull(products);
        Assert.Equal(6, products.Count);
    }

    [Fact]
    public async Task GetAll_FilterByPlatform_IgnoresCase()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products?platform=pc");

        Assert.NotNull(products);
        Assert.Equal(2, products.Count);
        Assert.All(products, p => Assert.Equal("PC", p.Platform));
    }

    [Fact]
    public async Task GetAll_FilterByGenre_ReturnsOnlyThatGenre()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products?genre=RPG");

        Assert.NotNull(products);
        var product = Assert.Single(products);
        Assert.Equal("Elden Ring", product.Name);
    }

    [Fact]
    public async Task GetAll_Search_MatchesPartOfTheName()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products?search=zelda");

        Assert.NotNull(products);
        var product = Assert.Single(products);
        Assert.Equal("Zelda: Tears of the Kingdom", product.Name);
    }

    [Fact]
    public async Task GetAll_MaxPrice_IncludesProductsWithThatExactPrice()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products?maxPrice=24.99");

        Assert.NotNull(products);
        Assert.Equal(2, products.Count); // Hades (24.99) y Stardew Valley (14.99)
        Assert.All(products, p => Assert.True(p.Price <= 24.99m));
    }

    [Fact]
    public async Task GetAll_CombinedFilters_AreAppliedTogether()
    {
        var products = await _client.GetFromJsonAsync<List<ProductDto>>("/api/products?search=zelda&platform=PC");

        Assert.NotNull(products);
        Assert.Empty(products);
    }

    [Fact]
    public async Task GetById_ExistingProduct_ReturnsDetail()
    {
        var product = await _client.GetFromJsonAsync<ProductDetailDto>("/api/products/1");

        Assert.NotNull(product);
        Assert.Equal("Elden Ring", product.Name);
        Assert.Equal("RPG", product.Genre);
        Assert.True(product.InStock);
    }

    [Fact]
    public async Task GetById_ProductWithoutStock_IsNotInStock()
    {
        var product = await _client.GetFromJsonAsync<ProductDetailDto>("/api/products/2");

        Assert.NotNull(product);
        Assert.False(product.InStock);
    }

    [Fact]
    public async Task GetById_UnknownId_ReturnsNotFound()
    {
        var response = await _client.GetAsync("/api/products/99");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task GetById_NonNumericId_ReturnsNotFound()
    {
        var response = await _client.GetAsync("/api/products/abc");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}
