using System.ComponentModel.DataAnnotations;
using Pavon.Domain.Abstractions.Common;
using Pavon.Domain.Bases.Entities;

namespace Pavon.Domain.Entities.DomainEntities;
public sealed class Category : BaseEntity, ITrackableCreate, ITrackableUpdate, ITrackableDelete, ISoftDeleteable
{
    [Required]
    [Length(2, 256)]
    public string Name { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }
    public bool IsDeleted { get; set; }

    public Category(string name, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt, bool isDeleted)
    {
        Name = name;
        CreatedAtUtc = createdAt;
        UpdatedAtUtc = updatedAt;
        DeletedAtUtc = deletedAt;
        IsDeleted = isDeleted;
    }
    public Category()
    {
        IsDeleted = false;
    }
}
