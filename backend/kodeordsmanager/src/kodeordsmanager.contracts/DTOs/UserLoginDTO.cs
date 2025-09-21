namespace kodeordsmanager.contracts.DTOs;

/// <summary>
///     Brugers oplysninger for login
/// </summary>
public class UserLoginDTO
{
    /// <summary>
    ///     Bruger Email
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// Bruger kodeord
    /// </summary>
    public string? Password { get; init; }
}