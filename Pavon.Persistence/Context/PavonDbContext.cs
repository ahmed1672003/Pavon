namespace Pavon.Persistence.Context;
public sealed class PavonDbContext : IdentityDbContext<User>, IPavonDbContext
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<User> Users => Set<User>();
}
