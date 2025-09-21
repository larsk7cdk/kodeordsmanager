namespace kodeordsmanager.contracts.DTOs;

/// <summary>
/// Retunerer en brugers applikationer
/// </summary>
public class ManagerDTO
{
    /// <summary>
    ///  Bruger Email
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// Tilknyttede applikationer
    /// </summary>
    public List<ManagerApplicationDTO> Applications { get; init; } = new();
}