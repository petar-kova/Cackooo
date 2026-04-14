using PrintStudio.Models;

namespace PrintStudio.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync(
        string? category = null,
        string? productType = null,
        string? sortBy = null,
        bool onlyOnSale = false,
        bool onlyBestSeller = false);

    Task<Product?> GetByIdAsync(int id);
    Task<Product> CreateAsync(Product product);
}
