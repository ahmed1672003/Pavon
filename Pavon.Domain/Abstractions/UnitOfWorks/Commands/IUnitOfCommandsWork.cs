namespace Pavon.Domain.Abstractions.UnitOfWorks.Commands;
public interface IUnitOfCommandsWork
{
    ICategoryCommandsRepository Categories { get; }
}
