using Microsoft.EntityFrameworkCore;
using PrintStudio.Models;

namespace PrintStudio.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Testimonial> Testimonials => Set<Testimonial>();
    public DbSet<ContactRequest> ContactRequests => Set<ContactRequest>();
}
