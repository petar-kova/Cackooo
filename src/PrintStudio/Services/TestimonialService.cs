using Microsoft.EntityFrameworkCore;
using PrintStudio.Data;
using PrintStudio.Models;

namespace PrintStudio.Services;

public class TestimonialService(AppDbContext db) : ITestimonialService
{
    public Task<List<Testimonial>> GetAllAsync() =>
        db.Testimonials.OrderByDescending(t => t.Rating).ToListAsync();
}
