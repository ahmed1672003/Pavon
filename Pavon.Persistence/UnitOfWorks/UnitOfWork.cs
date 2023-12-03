namespace Pavon.Persistence.UnitOfWorks;
public sealed class UnitOfWork : IUnitOfWork
{
    private readonly IPavonDbContext _dbContext;
    public IUnitOfCommandsWork Commands { get; }
    public IUnitOfQueriesWork Queries { get; }
    public UnitOfWork(IUnitOfCommandsWork commands, IUnitOfQueriesWork queries, IPavonDbContext dbContext)
    {
        Commands = commands;
        Queries = queries;
        _dbContext = dbContext;
    }
    public async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();
    public async Task<int> SaveChangesAsync(CancellationToken cancellation = default) => await _dbContext.SaveChangesAsync(cancellation);
}
