using HiringManagementSystem.Domains.DomainModels.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiringManagementSystem.Configurations
{
    public class TagConfigurations : IEntityTypeConfiguration<TagAggregate>
    {
        public void Configure(EntityTypeBuilder<TagAggregate> builder)
        {
            builder.ToTable("Tag");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.TagName);
            builder.Property(t => t.Description);
        }
    }
}
