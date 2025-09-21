using kodeordsmanager.domain.Models;

namespace kodeordsmanager.application.Auth;

public interface IAuthService
{
    Task<UserIdentityModel> LoginAsync(string email, string password);
}