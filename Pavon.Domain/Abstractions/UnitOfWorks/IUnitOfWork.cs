namespace Pavon.Domain.Abstractions.UnitOfWorks;
public interface IUnitOfWork : IAsyncDisposable
{
    IUnitOfCommandsWork Commands { get; }
    IUnitOfQueriesWork Queries { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);
}
