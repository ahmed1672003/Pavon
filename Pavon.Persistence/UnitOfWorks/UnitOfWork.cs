using Pavon.Domain.Abstractions.Repositories;
using Pavon.Domain.Abstractions.UnitOfWorks;

namespace Pavon.Persistence.UnitOfWorks;
public sealed class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IPavonDbContext context) => Context = context;
    private IPavonDbContext Context { get; }
    public ICommandsRepository<TEntity> GetCommandsRepository<TEntity>() where TEntity : class => new CommandsRepository<TEntity>(Context);
    public IQueriesRepository<TEntity> GetQueriesRepository<TEntity>() where TEntity : class => new QueriesRepository<TEntity>(Context);
    public Task<int> SaveChangesAsync(CancellationToken cancellation = default) => Context.SaveChangesAsync(cancellation);
    public ValueTask DisposeAsync() => Context.DisposeAsync();
}
