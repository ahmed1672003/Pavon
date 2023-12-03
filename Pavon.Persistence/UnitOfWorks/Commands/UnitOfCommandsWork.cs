namespace Pavon.Persistence.UnitOfWorks.Commands;
public class UnitOfCommandsWork : IUnitOfCommandsWork
{
    public UnitOfCommandsWork(ICategoryCommandsRepository categories) => Categories = categories;
    public ICategoryCommandsRepository Categories { get; }
}
