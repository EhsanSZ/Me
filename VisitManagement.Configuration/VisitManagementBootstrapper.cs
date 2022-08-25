using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VisitManagement.Infrastructure.EFCore;

namespace VisitManagement.Infrastructure.Configuration
{
    public class VisitManagementBootstrapper
    {
        public static void Configure(IServiceCollection services , string connectionString)
        {
            services.AddDbContext<VisitContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
