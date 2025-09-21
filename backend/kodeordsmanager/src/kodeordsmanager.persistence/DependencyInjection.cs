using kodeordsmanager.application.Interfaces;
using kodeordsmanager.persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kodeordsmanager.persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        // Service registrations
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IManagerRepository, ManagerRepository>();

        return services;
    }
}