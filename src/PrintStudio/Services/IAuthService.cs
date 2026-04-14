using PrintStudio.Models;

namespace PrintStudio.Services;

public interface IAuthService
{
    UserAccount? CurrentUser { get; }
    event Action? AuthStateChanged;
    Task<(bool Success, string Message)> RegisterAsync(UserAccount account);
    Task<(bool Success, string Message)> LoginAsync(string email, string password);
    void Logout();
}
