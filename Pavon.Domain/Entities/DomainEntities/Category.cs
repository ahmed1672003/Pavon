using System.ComponentModel.DataAnnotations;

using Pavon.Domain.Common.Abstracts;
using Pavon.Domain.Common.Bases;

namespace Pavon.Domain.Entities.DomainEntities;
public sealed class Category : BaseEntity, ITrackableCreate, ITrackableUpdate, ITrackableDelete, ISoftDeleteable
{
    [Required]
    [Length(2, 256)]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }

    public Category(string name, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt, bool isDeleted)
    {
        Name = name;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        DeletedAt = deletedAt;
        IsDeleted = isDeleted;
    }
    public Category()
    {
        IsDeleted = false;
    }
}
