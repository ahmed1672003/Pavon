using System.ComponentModel.DataAnnotations;

namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableCreate
{
    [Required]
    public DateTime CreatedAtUtc { get; set; }
    Task CreateAsync() => Task.Run(() => CreatedAtUtc = DateTime.UtcNow);
}
