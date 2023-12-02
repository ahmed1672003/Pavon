using Pavon.Domain.Entities.DomainEntities;

namespace Pavon.Application.Interfaces.Repositories;
public interface ICategoryRepository : IQueriesRepository<Category>, ICommandsRepository<Category>
{
}
