using kodeordsmanager.domain.Models;

namespace kodeordsmanager.application.Contracts.Interfaces.Auth;

public interface IAuthService
{
    Task<UserIdentityModel> LoginAsync(string email, string password);
}