namespace Pavon.Persistence.Context;
public sealed class PavonDbContext : IdentityDbContext<User>, IPavonDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<User> Users => Set<User>();
}
