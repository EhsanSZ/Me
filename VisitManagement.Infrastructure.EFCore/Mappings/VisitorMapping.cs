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

            builder.Property(x => x.IP).HasMaxLength(45);
            builder.Property(x => x.FamilyOS).HasMaxLength(30);
            builder.Property(x => x.Version).HasMaxLength(20);
            builder.Property(x => x.Brand).HasMaxLength(20);
            builder.Property(x => x.FamilyDevice).HasMaxLength(30);
            builder.Property(x => x.Model).HasMaxLength(20);
            builder.Property(x => x.VisitID).HasMaxLength(50);

        }
    }
}
