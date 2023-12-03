namespace Pavon.Persistence.Repositories.Commands;
public sealed class CategoryCommandsRepository : CommandsRepository<Category>, ICategoryCommandsRepository
{
    public CategoryCommandsRepository(IPavonDbContext context) : base(context) { }
}
