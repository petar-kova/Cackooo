using Microsoft.AspNetCore.Mvc;
using PrintStudio.Models;
using PrintStudio.Services;

namespace PrintStudio.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public Task<List<Product>> GetAll(
        [FromQuery] string? category,
        [FromQuery] string? productType,
        [FromQuery] string? sortBy,
        [FromQuery] bool onlyOnSale = false,
        [FromQuery] bool onlyBestSeller = false) =>
        productService.GetAllAsync(category, productType, sortBy, onlyOnSale, onlyBestSeller);

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await productService.GetByIdAsync(id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Create(Product product)
    {
        var created = await productService.CreateAsync(product);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
}
