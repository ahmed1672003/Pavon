namespace Pavon.Persistence;
public static class Registeration
{
    public static async Task<IServiceCollection> RegisterPersistence(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<IPavonDbContext, PavonDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("PavonDatabaseConnection")), ServiceLifetime.Scoped);

        services
            .AddScoped(typeof(ICommandsRepository<>), typeof(CommandsRepository<>))
            .AddScoped(typeof(IQueriesRepository<>), typeof(QueriesRepository<>));

        return services;
    }
}
