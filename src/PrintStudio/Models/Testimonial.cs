namespace PrintStudio.Models;

public class Testimonial
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string AvatarUrl { get; set; } = string.Empty;
}
