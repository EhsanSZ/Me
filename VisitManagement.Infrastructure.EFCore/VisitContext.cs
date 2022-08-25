using Microsoft.EntityFrameworkCore;
using VisitManagement.Domain.VisitAgg;
using VisitManagement.Infrastructure.EFCore.Mappings;

namespace VisitManagement.Infrastructure.EFCore
{
    public class VisitContext : DbContext
    {
        public DbSet<Visit> Visits { get; set; }
        public VisitContext(DbContextOptions<VisitContext> options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(VisitMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
