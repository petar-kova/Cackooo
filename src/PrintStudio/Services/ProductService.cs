using Microsoft.EntityFrameworkCore;
using PrintStudio.Data;
using PrintStudio.Models;

namespace PrintStudio.Services;

public class ProductService(AppDbContext db) : IProductService
{
    public Task<List<Product>> GetAllAsync(string? category = null)
    {
        var query = db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => p.Category == category);
        }

        return query.OrderBy(p => p.Name).ToListAsync();
    }

    public Task<Product?> GetByIdAsync(int id) =>
        db.Products.FirstOrDefaultAsync(p => p.Id == id);

    public async Task<Product> CreateAsync(Product product)
    {
        db.Products.Add(product);
        await db.SaveChangesAsync();
        return product;
    }
}
