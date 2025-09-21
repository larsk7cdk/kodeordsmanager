namespace kodeordsmanager.contracts.DTOs;
/// <summary>
/// Applikation oplysninger
/// </summary>
public class ManagerApplicationDTO
{
    /// <summary>
    /// Navn på applikationen
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Applikationens kodeord
    /// 
    public required string Password { get; init; }
}