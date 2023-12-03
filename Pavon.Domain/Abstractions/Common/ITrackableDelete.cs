namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableDelete
{
    public DateTime? DeletedAtUtc { get; set; }

    Task DeleteAsync() => Task.Run(() => DeletedAtUtc = DateTime.UtcNow);
}
