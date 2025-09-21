using kodeordsmanager.contracts.Entities;

namespace kodeordsmanager.application.Interfaces;

public interface IUserRepository
{
    Task<UserEntity> GetByEmailAsync(string email);
}