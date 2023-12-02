using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore.Query;
namespace Pavon.Application.Interfaces.Repositories;
public interface IQueriesRepository<TEntity>
{
    Task<IQueryable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? indlude = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        bool enableTracking = false,
        CancellationToken cancellation = default);
    Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellation = default);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null, CancellationToken cancellation = default);
}
