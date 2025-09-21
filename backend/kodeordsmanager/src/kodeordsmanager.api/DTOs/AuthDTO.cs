namespace kodeordsmanager.api.DTOs;

public class AuthDTO
{
    public required string Token { get; init; }

    public required long ExpiresIn { get; init; }
}