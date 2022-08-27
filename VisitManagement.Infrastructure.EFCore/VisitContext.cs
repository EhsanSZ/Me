using Microsoft.EntityFrameworkCore;
using VisitManagement.Domain.VisitorAgg;
using VisitManagement.Infrastructure.EFCore.Mappings;

namespace VisitManagement.Infrastructure.EFCore
{
    public class VisitContext : DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }
        public VisitContext(DbContextOptions<VisitContext> options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(VisitorMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
