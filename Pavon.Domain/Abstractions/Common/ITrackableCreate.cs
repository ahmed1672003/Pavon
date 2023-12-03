using System.ComponentModel.DataAnnotations;

namespace Pavon.Domain.Abstractions.Common;
public interface ITrackableCreate
{
    [Required]
    public DateTime CreatedAt { get; set; }
}
