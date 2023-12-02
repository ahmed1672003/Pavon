using Microsoft.EntityFrameworkCore.Storage;
namespace Pavon.Application.Interfaces.Repositories;
public interface IUnitOfWork
{
    ICategoryRepository Categoreies { get; }
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellation);
    Task<int> SaveChangesAsync(CancellationToken cancellation = default);
}
