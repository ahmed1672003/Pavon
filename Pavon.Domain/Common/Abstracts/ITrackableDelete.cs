namespace Pavon.Domain.Common.Abstracts;
public interface ITrackableDelete
{
    public DateTime? DeletedAt { get; set; }
}
