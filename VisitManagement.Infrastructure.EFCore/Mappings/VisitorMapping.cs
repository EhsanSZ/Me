using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitManagement.Domain.VisitorAgg;

namespace VisitManagement.Infrastructure.EFCore.Mappings
{
    public class VisitorMapping : IEntityTypeConfiguration<Visitor>
    {
        public void Configure (EntityTypeBuilder<Visitor> builder)
        {
            builder.ToTable("Visitors");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.IP).HasMaxLength(50);
            builder.Property(x => x.FamilyOS).HasMaxLength(50);
            builder.Property(x => x.Version).HasMaxLength(50);
            builder.Property(x => x.Brand).HasMaxLength(50);
            builder.Property(x => x.FamilyDevice).HasMaxLength(50);
            builder.Property(x => x.Model).HasMaxLength(50);

        }
    }
}
