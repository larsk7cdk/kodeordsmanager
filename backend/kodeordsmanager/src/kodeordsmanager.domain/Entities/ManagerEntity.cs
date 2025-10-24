using kodeordsmanager.domain.Entities.Shared;

namespace kodeordsmanager.domain.Entities;

public class ManagerEntity : BaseEntity
{
    public List<ManagerApplicationEntity> ManagerApplications { get; init; } = [];
}