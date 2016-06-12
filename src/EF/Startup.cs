using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;

//dnx ef migrations remove
//dnx ef migrations add init
//dnx ef database update

namespace EF
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
                    .AddSqlServer()
                    .AddDbContext<EfContext>(options =>
                    {
                        options.UseSqlServer(Configuration["Data:ConnectionString"]);
                    });
        }

        public void Configure(IApplicationBuilder app)
        {
        }
    }
}
