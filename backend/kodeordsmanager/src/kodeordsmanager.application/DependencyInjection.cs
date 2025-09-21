using kodeordsmanager.application.Auth;
using kodeordsmanager.domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kodeordsmanager.application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        // Configuration bindings
        services.Configure<JwtModel>(configuration.GetSection("Jwt"));

        // Service registrations
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}