namespace Pavon.Domain.Common.Abstracts;
public interface ISoftDeleteable
{
    public bool IsDeleted { get; set; }
}
