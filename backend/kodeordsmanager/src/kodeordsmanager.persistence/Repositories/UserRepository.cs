using kodeordsmanager.application.Contracts.Interfaces.Persistence;
using kodeordsmanager.domain.Entities;
using kodeordsmanager.persistence.DatabaseContext;
using kodeordsmanager.persistence.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace kodeordsmanager.persistence.Repositories;

public class UserRepository(AppDatabaseContext context)
    : GenericRepository<UserEntity>(context), IUserRepository
{
    private readonly AppDatabaseContext _context = context;

    public async Task<UserEntity?> GetByEmailAsync(string email) =>
        await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
}