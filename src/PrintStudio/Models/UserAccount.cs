using System.ComponentModel.DataAnnotations;

namespace PrintStudio.Models;

public class UserAccount
{
    public int Id { get; set; }

    [Required]
    [StringLength(80)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
}
