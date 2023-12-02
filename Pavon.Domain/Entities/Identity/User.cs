namespace Pavon.Domain.Entities.Identity;
public sealed class User : IdentityUser
{
    [NotMapped]
    public override string? PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

    [NotMapped]
    public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
}
