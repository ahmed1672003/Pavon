namespace Pavon.Service.UnitOfServices.Commands;
public sealed class UnitOfCommandsService : IUnitOfCommandsServices
{
    public UnitOfCommandsService(ICategoryCommandsService categories) => Categories = categories;

    public ICategoryCommandsService Categories { get; }
}
