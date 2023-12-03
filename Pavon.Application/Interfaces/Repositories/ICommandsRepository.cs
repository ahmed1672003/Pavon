using System.Linq.Expressions;

namespace Pavon.Application.Interfaces.Repositories;
public interface ICommandsRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity, CancellationToken cancellation = default);
    Task UpdateAsync(TEntity entity, CancellationToken cancellation = default);
    Task DeleteAsync(TEntity entity, CancellationToken cancellation = default);
    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
    Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
    Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
    Task<int> ExecuteUpdateAsync(Expression<Func<TEntity, bool>> predicate, Func<TEntity, object> propertyExpression, Expression<Func<TEntity, object>> valuesExpression, CancellationToken cancellation = default);
    Task<int> ExecuteDeleteAsync(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellation = default);
}
