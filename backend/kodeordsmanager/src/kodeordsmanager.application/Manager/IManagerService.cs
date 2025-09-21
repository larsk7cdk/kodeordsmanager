using kodeordsmanager.domain.Models;

namespace kodeordsmanager.application.Manager;

public interface IManagerService
{
    Task<ManagerModel> GetAllAsync(string email);
}