using CleanArch.Core.Application.Services.Persons;
using CleanArch.Core.Contracts.IRepositories.Persons;
using CleanArch.Core.Contracts.IServices.Persons;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Infrastructure.Data.Repositories.Persons;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.API
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
            services.AddControllers();
            services.AddDbContext<CleanArchDbContext>(options =>
            {
                //options.UseSqlServer(Configuration.GetConnectionString("EshopApiDBConecnection"));
                options.UseSqlServer("Server=DESKTOP-98REPCN\\SQL2019DEVELOPER; Database=ArchitectureDB; User ID=sa; Password=123");

            });

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddResponseCaching();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
