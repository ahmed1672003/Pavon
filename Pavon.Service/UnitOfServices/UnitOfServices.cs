using Pavon.Application.Abstractions.UnitOfServices;


namespace Pavon.Service.UnitOfServices;
public sealed class UnitOfServices : IUnitOfService
{
    public UnitOfServices(IUnitOfCommandsServices commands, IUnitOfQueriesServices queries)
    {
        Commands = commands;
        Queries = queries;
    }

    public IUnitOfCommandsServices Commands { get; }
    public IUnitOfQueriesServices Queries { get; }
}
