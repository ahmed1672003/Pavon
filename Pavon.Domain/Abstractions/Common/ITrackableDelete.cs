namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableDelete
{
    public DateTime? DeletedAt { get; set; }
}
