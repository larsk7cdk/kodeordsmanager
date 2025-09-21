namespace kodeordsmanager.contracts.DTOs;

/// <summary>
/// Brugers oplysninger for at hente applikationer
/// </summary>
public class UserManagerDTO
{
    /// <summary>
    ///     Bruger Email
    /// </summary>
    public required string Email { get; init; }
}