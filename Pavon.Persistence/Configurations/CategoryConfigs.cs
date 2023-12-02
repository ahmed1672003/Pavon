using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pavon.Persistence.Configurations;
public sealed class CategoryConfigs : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
    }
}
