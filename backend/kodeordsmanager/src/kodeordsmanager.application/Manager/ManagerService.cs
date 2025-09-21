using kodeordsmanager.application.Interfaces;
using kodeordsmanager.domain.Models;

namespace kodeordsmanager.application.Manager;

public class ManagerService(IManagerRepository managerRepository) : IManagerService
{
    public async Task<ManagerModel> GetAllAsync(string email)
    {
        var manager = await managerRepository.GetByEmailAsync(email);

        return await Task.FromResult(new ManagerModel
        {
            Email = manager.User.Email,
            ManagerApplications = manager.ManagerApplications.Select(s => new ManagerApplicationModel
            {
                Name = s.Name,
                Password = s.Password
            }).ToList()
        });
    }
}