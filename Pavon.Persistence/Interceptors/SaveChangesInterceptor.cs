namespace Pavon.Persistence.Interceptors;
public sealed class SaveChangesInterceptor : Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor
{
    public sealed override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        if (eventData.Context is null)
            return result;

        foreach (var entry in eventData.Context.ChangeTracker.Entries())
        {
            if (entry is not { State: EntityState.Added, Entity: ITrackableCreate entity })
                continue;

            await entity.CreateAsync();
        }

        foreach (var entry in eventData.Context.ChangeTracker.Entries())
        {
            //if (entry is null || entry.State != EntityState.Deleted || entry.Entity is not ISoftDeleteable)
            if (entry is not { State: EntityState.Deleted, Entity: ITrackableDelete entity })
                continue;

            entry.State = EntityState.Modified;
            await entity.DeleteAsync();
        }

        foreach (var entry in eventData.Context.ChangeTracker.Entries())
        {
            //if (entry is null || entry.State != EntityState.Deleted || entry.Entity is not ISoftDeleteable)
            if (entry is not { State: EntityState.Deleted, Entity: ISoftDeleteable entity })
                continue;

            entry.State = EntityState.Modified;
            await entity.SoftDeleteAsync();
        }

        foreach (var entry in eventData.Context.ChangeTracker.Entries())
        {
            //if (entry is null || entry.State != EntityState.Modified || entry.Entity is not IUpdateableTracker)
            if (entry is not { State: EntityState.Modified, Entity: ITrackableUpdate entity })
                continue;
            await entity.UpdateAsync();
        }
        return result;
    }
}
