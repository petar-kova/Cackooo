using Microsoft.EntityFrameworkCore;
using PrintStudio.Data;
using PrintStudio.Models;

namespace PrintStudio.Services;

public class ProductService(AppDbContext db) : IProductService
{
    public Task<List<Product>> GetAllAsync(
        string? category = null,
        string? productType = null,
        string? sortBy = null,
        bool onlyOnSale = false,
        bool onlyBestSeller = false)
    {
        var query = db.Products.AsQueryable();

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(p => p.Category == category);
        }

        if (!string.IsNullOrWhiteSpace(productType))
        {
            query = query.Where(p => p.ProductType == productType);
        }

        if (onlyOnSale)
        {
            query = query.Where(p => p.IsOnSale);
        }

        if (onlyBestSeller)
        {
            query = query.Where(p => p.IsBestSeller);
        }

        query = sortBy switch
        {
            "price-asc" => query.OrderBy(p => p.Price),
            "price-desc" => query.OrderByDescending(p => p.Price),
            "name-desc" => query.OrderByDescending(p => p.Name),
            _ => query.OrderBy(p => p.Name)
        };

        return query.ToListAsync();
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
