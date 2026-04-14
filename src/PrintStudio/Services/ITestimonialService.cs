using PrintStudio.Models;

namespace PrintStudio.Services;

public interface ITestimonialService
{
    Task<List<Testimonial>> GetAllAsync();
}
