using Pavon.Application.Abstractions.UnitOfServices.Queries;
namespace Pavon.Service.UnitOfServices.Queries;
public sealed class UnitOfQueriesService : IUnitOfQueriesServices
{
    public UnitOfQueriesService(ICategoryQueriesService categories) => Categories = categories;
    public ICategoryQueriesService Categories { get; }
}
