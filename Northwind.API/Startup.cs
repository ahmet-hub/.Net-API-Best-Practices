using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.Service;
using NorthwindFramework.Core.UnitOfWork;
using NorthwindFramework.DataAccess;
using NorthwindFramework.DataAccess.Repositories;
using NorthwindFramework.DataAccess.UnitOfWork;
using NorthwindFramework.Service.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NorthwindFramework.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
            services.AddScoped(typeof(IEntityService<>), typeof(Service<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
          


            services.AddDbContext<NorthwindContext>(options =>
            {          
              options.UseSqlServer(Configuration
                ["ConnectionStrings:SqlConStr"].ToString(),
             o =>
                {
                o.MigrationsAssembly("NorthwindFramework.DataAccess");
                });
            });
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; }); 
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
