using Itmo.Dev.Platform.Postgres.Plugins;
using Npgsql;

namespace Website_for_searching_and_booking_tours_and_travel.Infrastructure.Persistence.Plugins;

/// <summary>
///     Plugin for configuring NpgsqlDataSource's mappings
///     ie: enums, composite types
/// </summary>
public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder) { }
}