namespace kodeordsmanager.domain.Models;

public class JwtModel
{
    public required string Key { get; init; }
    public required string Issuer { get; init; }
    public required string Audience { get; init; }
    public required double DurationInMinutes { get; init; }
}