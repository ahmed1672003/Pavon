namespace Pavon.Persistence.UnitOfWorks.Queries;
public class UnitOfQueriesWork : IUnitOfQueriesWork
{
    public UnitOfQueriesWork(ICategoryQueriesRepository categories) => Categories = categories;
    public ICategoryQueriesRepository Categories { get; }
}
