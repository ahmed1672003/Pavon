namespace Pavon.Domain.Abstractions.UnitOfWorks.Queries;
public interface IUnitOfQueriesWork
{
    ICategoryQueriesRepository Categories { get; }
}
