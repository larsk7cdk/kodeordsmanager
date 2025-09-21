using kodeordsmanager.application.Interfaces;
using kodeordsmanager.contracts.Entities;

namespace kodeordsmanager.persistence.Repositories;

public class ManagerRepository(IUserRepository userRepository) : IManagerRepository
{
    private readonly List<ManagerApplicationEntity> _managerApplicationEntities =
    [
        new() { UserId = 1, Name = "UserApp1", Password = "123" },
        new() { UserId = 1, Name = "UserApp2", Password = "123" },
        new() { UserId = 1, Name = "USerApp3", Password = "123" },

        new() { UserId = 2, Name = "LarsApp1", Password = "123" },
        new() { UserId = 2, Name = "LarsApp2", Password = "123" },
        new() { UserId = 2, Name = "LarsApp3", Password = "123" },
    ];


    public async Task<ManagerEntity> GetByEmailAsync(string email)
    {
        var user = await userRepository.GetByEmailAsync(email);
        var managerApplications = _managerApplicationEntities.Where(m => m.UserId == user.Id).ToList();

        return await Task.FromResult(new ManagerEntity
        {
            User = user,
            ManagerApplications = managerApplications
        });
    }
}