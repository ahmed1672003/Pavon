namespace Pavon.Application.Abstractions.UnitOfServices;
public interface IUnitOfService
{
    IUnitOfCommandsServices Commands { get; }
    IUnitOfQueriesServices Queries { get; }
}
