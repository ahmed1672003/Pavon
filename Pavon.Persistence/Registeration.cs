using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Pavon.Persistence;
public static class Registeration
{
    public static async Task<IServiceCollection> RegisterPersistence(this IServiceCollection services, IConfiguration config)
    {

        return services;
    }
}
