using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pavon.Persistence.Configurations;
public sealed class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
    }
}
