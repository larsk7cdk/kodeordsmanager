using kodeordsmanager.application.Contracts.Interfaces.Persistence;
using kodeordsmanager.domain.Entities;
using kodeordsmanager.persistence.DatabaseContext;
using kodeordsmanager.persistence.Repositories.Shared;

namespace kodeordsmanager.persistence.Repositories;

public class ManagerRepository(AppDatabaseContext context)
    : GenericRepository<ManagerEntity>(context), IManagerRepository
{
}