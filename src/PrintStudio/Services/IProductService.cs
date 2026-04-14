using PrintStudio.Models;

namespace PrintStudio.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync(string? category = null);
    Task<Product?> GetByIdAsync(int id);
    Task<Product> CreateAsync(Product product);
}
