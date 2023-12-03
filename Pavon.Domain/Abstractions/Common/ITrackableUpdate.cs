namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableUpdate
{
    public DateTime? UpdatedAtUtc { get; set; }

    Task UpdateAsync() => Task.Run(() => UpdatedAtUtc = DateTime.UtcNow);
}
