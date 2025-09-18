using kodeordsmanager.domain.Models;

namespace kodeordsmanager.application.Auth;

public interface IAuthService
{
    Task<UserModel> Login(string email, string password);
}