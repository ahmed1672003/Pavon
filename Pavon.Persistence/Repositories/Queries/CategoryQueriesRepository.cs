namespace Pavon.Persistence.Repositories.Queries;
public sealed class CategoryQueriesRepository : QueriesRepository<Category>, ICategoryQueriesRepository
{
    public CategoryQueriesRepository(IPavonDbContext context) : base(context) { }
}
