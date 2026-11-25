using GameStore.Application.Features.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(ProductService productService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<ProductDto>>> GetAll(
        [FromQuery] string? search,
        [FromQuery] string? platform,
        [FromQuery] string? genre,
        [FromQuery] decimal? maxPrice) =>
        Ok(await productService.GetAllAsync(new ProductFilter(search, platform, genre, maxPrice)));

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductDetailDto>> GetById(int id)
    {
        var product = await productService.GetByIdAsync(id);
        return product is null ? NotFound() : Ok(product);
    }
}
