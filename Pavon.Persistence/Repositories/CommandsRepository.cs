using System.Linq.Expressions;

using Pavon.Application.Interfaces.Repositories;

namespace Pavon.Persistence.Repositories;
public sealed class CommandsRepository<TEntity>(IPavonDbContext context) : ICommandsRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _entities = context.Set<TEntity>();
    public async Task AddAsync(TEntity entity, CancellationToken cancellation = default) => await _entities.SingleInsertAsync(entity, cancellation);
    public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default) => await _entities.BulkInsertOptimizedAsync(entities, cancellation);
    public async Task DeleteAsync(TEntity entity, CancellationToken cancellation = default) => await _entities.SingleDeleteAsync(entity, cancellation);
    public async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default) => await _entities.BulkInsertOptimizedAsync(entities, cancellation);
    public async Task<int> ExecuteDeleteAsync(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellation = default)
    {
        if (predicate is not null)
            return await _entities.Where(predicate).ExecuteDeleteAsync(cancellation);

        return await _entities.ExecuteDeleteAsync(cancellation);
    }
    public async Task<int> ExecuteUpdateAsync(Expression<Func<TEntity, bool>> predicate, Func<TEntity, object> propertyExpression, Expression<Func<TEntity, object>> valuesExpression, CancellationToken cancellation = default)
    {
        if (predicate is not null)
            return await _entities.Where(predicate).ExecuteUpdateAsync(prop =>
            prop.SetProperty(propertyExpression, valuesExpression));

        return await _entities.ExecuteUpdateAsync(prop =>
          prop.SetProperty(propertyExpression, valuesExpression));
    }
    public async Task UpdateAsync(TEntity entity, CancellationToken cancellation = default) =>
     await _entities.SingleUpdateAsync(entity, cancellation);
    public async Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default) => await _entities.BulkUpdateAsync(entities, cancellation);
}
