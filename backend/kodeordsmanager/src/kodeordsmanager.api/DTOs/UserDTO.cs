namespace kodeordsmanager.api.DTOs;

/// <summary>
///     Bruger oplysninger
/// </summary>
public class UserDTO
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