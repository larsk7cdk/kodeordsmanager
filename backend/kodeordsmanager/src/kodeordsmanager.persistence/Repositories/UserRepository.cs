using kodeordsmanager.application.Interfaces;
using kodeordsmanager.contracts.Entities;

namespace kodeordsmanager.persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly List<UserEntity> _userEntities =
    [
        new() { Id = 1, Email = "user@kodeordsmanager.dk", Password = "Kodeord123!" },
        new() { Id = 2, Email = "lars@kodeordsmanager.dk", Password = "Kodeord456!" }
    ];

    public async Task<UserEntity> GetByEmailAsync(string email)
    {
        var user = _userEntities.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        return await Task.FromResult(user) ?? new UserEntity { Id = 0, Email = string.Empty, Password = string.Empty };
    }
}