using Microsoft.AspNetCore.Mvc;
using PrintStudio.Models;
using PrintStudio.Services;

namespace PrintStudio.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialsController(ITestimonialService testimonialService) : ControllerBase
{
    [HttpGet]
    public Task<List<Testimonial>> GetAll() => testimonialService.GetAllAsync();
}
