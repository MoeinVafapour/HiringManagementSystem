using HiringManagementSystem.Domains.DomainModels.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;

namespace HiringManagementSystem.Configurations
{
    public class PersonConfigurations : IEntityTypeConfiguration<PersonAggregate>
    {
        public void Configure(EntityTypeBuilder<PersonAggregate> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.Family).IsRequired();
            builder.Property(p => p.NationalId).IsRequired();
            builder.HasMany(p => p.Tags).WithOne(t => t.Person).HasForeignKey(t => t.PersonId);
        }
    }
}
