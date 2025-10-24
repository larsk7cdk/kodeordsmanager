using kodeordsmanager.domain.Entities;

namespace kodeordsmanager.application.Contracts.Interfaces.Persistence;

public interface IUserRepository : IGenericRepository<UserEntity>
{
    Task<UserEntity?> GetByEmailAsync(string email);
}