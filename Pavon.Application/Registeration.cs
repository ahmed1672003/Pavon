using Microsoft.Extensions.DependencyInjection;

namespace Pavon.Application;
public static class Registeration
{
    public static async Task<IServiceCollection> RegisterApplication(this IServiceCollection services)
    {
        return services;
    }
}
