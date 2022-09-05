using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VisitManagement.Domain.MessageAgg;

namespace VisitManagement.Infrastructure.EFCore.Mappings
{
    public class MessageMapping : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);
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
