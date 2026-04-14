using System.ComponentModel.DataAnnotations;

namespace PrintStudio.Models;

public class ContactRequest
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Message { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}
