namespace kodeordsmanager.contracts.Entities;

public class UserEntity
{
    public required int Id { get; set; }
    public required string Email { get; init; }
    public required string Password { get; init; }
}