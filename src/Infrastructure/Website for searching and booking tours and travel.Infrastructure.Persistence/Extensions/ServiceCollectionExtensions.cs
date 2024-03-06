using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Website_for_searching_and_booking_tours_and_travel.Application.Abstractions.Persistence;
using Website_for_searching_and_booking_tours_and_travel.Infrastructure.Persistence.Migrations;
using Website_for_searching_and_booking_tours_and_travel.Infrastructure.Persistence.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Website_for_searching_and_booking_tours_and_travel.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection)
    {
        collection.AddPlatformPostgres(builder => builder.BindConfiguration("Infrastructure:Persistence:Postgres"));
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        collection.AddHostedService<MigrationRunnerService>();

        // TODO: add repositories
        collection.AddScoped<IPersistenceContext, PersistenceContext>();

        return collection;
    }
}