using System.Reflection;
using LicenceKey.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.Entities;

namespace LicenceKey.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var mongoDbConfiguration = new MongoDbConfiguration();
        configuration.GetSection("MongoDbConfiguration")
            .Bind(mongoDbConfiguration);
        
        Task.Run(async () =>
            {
                await DB.InitAsync(mongoDbConfiguration.DatabaseName!,
                    MongoClientSettings.FromConnectionString(mongoDbConfiguration.ConnectionString));
            })
            .GetAwaiter()
            .GetResult();

        return serviceCollection;
    }
}
