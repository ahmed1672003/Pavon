using Pavon.Application.Abstractions.Services;

namespace Pavon.Application.Abstractions.UnitOfServices;
internal interface IUnitOfServices
{
    ICategoryService Categories { get; }
}
