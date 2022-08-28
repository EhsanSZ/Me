using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VisitManagement.Application;
using VisitManagement.ApplicationContracts.Visitor;
using VisitManagement.Domain.VisitorAgg;
using VisitManagement.Infrastructure.EFCore;
using VisitManagement.Infrastructure.EFCore.Repository;

namespace VisitManagement.Infrastructure.Configuration
{
    public class VisitManagementBootstrapper
    {
        public static void Configure(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IVisitorApplication, VisitorApplication>();
            services.AddTransient<IVisitorRepository, VisitorRepository>();

            services.AddDbContext<VisitContext>(x => x.UseSqlServer(connectionString));

        }
    }
}
