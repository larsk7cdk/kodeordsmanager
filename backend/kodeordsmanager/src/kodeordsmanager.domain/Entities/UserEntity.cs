using kodeordsmanager.domain.Entities.Shared;

namespace kodeordsmanager.domain.Entities;

public class UserEntity : BaseEntity
{
    public required string Email { get; init; }
    public required string Password { get; init; }
}