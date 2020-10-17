using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using TourApi.Data;
using TourApi.Models.IRepository;
using TourApi.Data.Repository;
using TourApi.Mapping;


namespace TourApi
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
            services.AddControllers().AddNewtonsoftJson(options =>
                             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); ;
            services.AddDbContext<TourContext>(options =>
            {
                options.UseSqlite("Data Source=TourContext.db",
              x => x.MigrationsAssembly("TourApi"));

                options.UseLazyLoadingProxies();
            });
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICostRepository, CostRepository>();
            services.AddScoped<ITourPriceRepository, TourPriceRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ITypesOfTourismRepository, TypesOfTourismRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<ITouristGroupRepository, TouristGroupRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
