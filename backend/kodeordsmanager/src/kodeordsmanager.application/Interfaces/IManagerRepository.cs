using kodeordsmanager.contracts.Entities;

namespace kodeordsmanager.application.Interfaces;

public interface IManagerRepository
{
    Task<ManagerEntity> GetByEmailAsync(string email);
}