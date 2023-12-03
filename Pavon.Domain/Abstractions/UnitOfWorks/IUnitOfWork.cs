using Pavon.Domain.Abstractions.Repositories;

namespace Pavon.Domain.Abstractions.UnitOfWorks;
public interface IUnitOfWork : IAsyncDisposable
{
    IQueriesRepository<TEntity> GetQueriesRepository<TEntity>() where TEntity : class;
    ICommandsRepository<TEntity> GetCommandsRepository<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);
}
