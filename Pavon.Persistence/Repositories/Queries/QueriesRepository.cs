namespace Pavon.Persistence.Repositories.Queries;
public class QueriesRepository<TEntity>(IPavonDbContext context) : IQueriesRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _entities = context.Set<TEntity>();
    public Task<IQueryable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        bool enableTracking = false, CancellationToken cancellation = default)
    {
        IQueryable<TEntity> query = _entities.AsQueryable();

        if (!enableTracking)
            query = query.AsNoTracking();

        if (predicate is not null)
            query = query.Where(predicate);

        if (include is not null)
            query = include(query);

        if (orderBy is not null)
            query = orderBy(query);
        return Task.FromResult(query);
    }
    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellation = default)
    {
        if (predicate is not null)
            return await _entities.AsNoTracking().AnyAsync(predicate);

        return await _entities.AsNoTracking().AnyAsync();
    }
    public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellation = default)
    {
        if (predicate is not null)
            return await _entities.AsNoTracking().CountAsync(predicate);

        return await _entities.AsNoTracking().CountAsync();
    }
}
