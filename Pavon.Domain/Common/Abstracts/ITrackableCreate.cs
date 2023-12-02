using System.ComponentModel.DataAnnotations;

namespace Pavon.Domain.Common.Abstracts;
public interface ITrackableCreate
{
    [Required]
    public DateTime CreatedAt { get; set; }
}
