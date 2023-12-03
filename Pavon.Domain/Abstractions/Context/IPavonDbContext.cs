namespace Pavon.Application.Interfaces.Context;
public interface IPavonDbContext
{
    DbSet<Category> Categories { get; }
    DbSet<User> Users { get; }
    DatabaseFacade Database { get; }
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);

    ValueTask DisposeAsync();
}
