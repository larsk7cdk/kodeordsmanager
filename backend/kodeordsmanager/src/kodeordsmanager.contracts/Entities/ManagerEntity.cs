namespace kodeordsmanager.contracts.Entities;

public class ManagerEntity
{
    public required UserEntity User { get; init; }
    public List<ManagerApplicationEntity> ManagerApplications { get; init; } = [];
}