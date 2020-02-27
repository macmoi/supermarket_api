using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using AutoMapper;
using supermarket_api.Persistence.Contexts;
using supermarket_api.Domain.Services;
using supermarket_api.Domain.Repositories;
using supermarket_api.Services;
using supermarket_api.Persistence.Repositories;


namespace supermarket_api
{
    public class Startup
    {
        /*
            DEV LEARNING NOTES:

            The ConfigureServices and Configure methods are called at runtime 
            by the framework pipeline to configure how the application should 
            work and which components it must use.

            Have a look at the ConfigureServices method. Here we only have one line, 
            that configures the application to use the MVC pipeline, which basically 
            means the application is going to handle requests and responses using controller classes 
            (there are more things happening here behind the scenes, but that’s what you need to know for now).

            We can use the ConfigureServices method, accessing the services parameter, 
            to configure our dependency bindings.
        */

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContextPool<AppDbContext>(p =>
                p.UseMySql(Configuration.GetConnectionString("DBConnection"), op => op.ServerVersion(new Version(5,7,29), ServerType.MySql))
            );
            
            // Binding Services to their dependencies
            /**for more info @see https://docs.microsoft.com/es-es/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2*/
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CateogryService>();
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
