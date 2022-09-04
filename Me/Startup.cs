using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisitManagement.Application;
using VisitManagement.ApplicationContracts.Visitor;
using VisitManagement.Infrastructure.Configuration;
using WebMarkupMin.AspNetCore5;

namespace Me
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            
            var connectionString = Configuration.GetConnectionString("EhsanSQL");
            VisitManagementBootstrapper.Configure(services, connectionString);

            services.AddHttpContextAccessor();
            services.AddResponseCaching();
            services.AddSession();
            services.AddWebMarkupMin()
                .AddHtmlMinification();

            services.AddTransient<SaveVisitorFilter>();

            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseWebMarkupMin();

            app.UseCookiePolicy();
            app.UseSession();

            app.UseRouting();

			app.UseAuthorization();

            //app.UseMiddleware<ApplicationVariable>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
