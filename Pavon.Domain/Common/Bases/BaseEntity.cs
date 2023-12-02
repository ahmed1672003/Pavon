using System.ComponentModel.DataAnnotations;

namespace Pavon.Domain.Common.Bases;
public class BaseEntity
{
    [Length(64, 64)]
    public string Id { get; set; }
    public BaseEntity() => Id = $"{Guid.NewGuid()}{Guid.NewGuid()}".Replace("-", string.Empty);
}
