using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using AspNetCoreWebApiApp.Domains;
using AspNetCoreWebApiApp.Services;

namespace AspNetCoreWebApiApp
{
    public class Startup
    {
        public const string CONNECTION_STRING = "Data:DefaultConnectionString";

        public IConfigurationRoot Configuration { get; private set; }

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config/appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"config/appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<DatabaseContext>(
                  options => options.UseNpgsql(Configuration[CONNECTION_STRING])
                )
                .AddMvcCore()
                .AddJsonFormatters();
            services.AddScoped<IProductService, ProductService>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            app.UseMvc();
        }
    }
}
