using kodeordsmanager.application.Contracts.Interfaces.Persistence;
using kodeordsmanager.persistence.DatabaseContext;
using kodeordsmanager.persistence.Repositories;
using kodeordsmanager.persistence.Repositories.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kodeordsmanager.persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDatabaseContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("AppDatabaseConnectionString"));
        });

        // Service registrations
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IManagerRepository, ManagerRepository>();


        return services;
    }
}