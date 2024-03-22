using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.Domain.Entities;

namespace OA.Infra.Persistence.Configuration
{
    public sealed class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(256);
        }
    }
}
