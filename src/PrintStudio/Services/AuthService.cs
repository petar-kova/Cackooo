using PrintStudio.Models;

namespace PrintStudio.Services;

public class AuthService : IAuthService
{
    private static readonly List<UserAccount> Users =
    [
        new UserAccount
        {
            Id = 1,
            FullName = "Demo Korisnik",
            Email = "demo@akrilshop.hr",
            Password = "Demo123"
        }
    ];

    private static readonly object LockObj = new();

    public UserAccount? CurrentUser { get; private set; }
    public event Action? AuthStateChanged;

    public Task<(bool Success, string Message)> RegisterAsync(UserAccount account)
    {
        lock (LockObj)
        {
            if (Users.Any(u => u.Email.Equals(account.Email, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.FromResult((false, "Račun s tim emailom već postoji."));
            }

            account.Id = Users.Max(x => x.Id) + 1;
            Users.Add(account);
            CurrentUser = account;
        }

        AuthStateChanged?.Invoke();
        return Task.FromResult((true, "Uspješna registracija. Dobro došli!"));
    }

    public Task<(bool Success, string Message)> LoginAsync(string email, string password)
    {
        UserAccount? user;

        lock (LockObj)
        {
            user = Users.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            if (user is null)
            {
                return Task.FromResult((false, "Neispravni podaci za prijavu."));
            }

            CurrentUser = user;
        }

        AuthStateChanged?.Invoke();
        return Task.FromResult((true, $"Dobro došli, {user.FullName}!"));
    }

    public void Logout()
    {
        CurrentUser = null;
        AuthStateChanged?.Invoke();
    }
}
