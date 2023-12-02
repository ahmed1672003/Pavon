using Microsoft.EntityFrameworkCore.Storage;

using Pavon.Application.Interfaces.Repositories;

namespace Pavon.Persistence.Repositories;
public sealed class UnitOfWork : IUnitOfWork
{
    public ICategoryRepository Categoreies { get; }
    private IPavonDbContext Context { get; }
    public UnitOfWork(ICategoryRepository categoreies, IPavonDbContext context)
    {
        Categoreies = categoreies;
        Context = context;
    }
    public async Task<int> SaveChangesAsync(CancellationToken cancellation = default) => await Context.SaveChangesAsync(cancellation);
    public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellation) => await Context.Database.BeginTransactionAsync(cancellation);
}
