namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableUpdate
{
    public DateTime? UpdatedAt { get; set; }
}
