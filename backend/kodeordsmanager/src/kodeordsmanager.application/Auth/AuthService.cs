using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using kodeordsmanager.domain.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace kodeordsmanager.application.Auth;

public class AuthService(IOptions<JwtModel> jwt) : IAuthService
{
    private readonly List<KeyValuePair<string, string>> _users =
    [
        new("user@kodeordsmanager.dk", "Kodeord123!"),
        new("lars@kodeordsmanager.dk", "Kodeord456!"),
    ];


    public async Task<UserModel> Login(string email, string password)
    {
        var status = string.Empty;
        var jwtToken = string.Empty;

        var (key, value) = _users.FirstOrDefault(x => x.Key == email);

        if (email != key || password != value)
        {
            status = "Invalid Email or Password.";
        }
        else
        {
            jwtToken = await CreateJwtToken(email);
        }

        return await Task.FromResult(new UserModel
        {
            Email = email,
            IsAuthenticated = !string.IsNullOrEmpty(jwtToken),
            JwtToken = jwtToken,
            Status = string.IsNullOrEmpty(status) ? "Success" : status
        });
    }

    private async Task<string> CreateJwtToken(string email)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Sub, email),
            new Claim(JwtRegisteredClaimNames.Email, email),
        };
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Value.Key));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
        var jwtSecurityToken = new JwtSecurityToken(
            jwt.Value.Issuer,
            jwt.Value.Audience,
            claims,
            expires: DateTime.UtcNow.AddMinutes(jwt.Value.DurationInMinutes),
            signingCredentials: signingCredentials);

        var jwtSecurityTokenString = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        return await Task.FromResult(jwtSecurityTokenString);
    }
}