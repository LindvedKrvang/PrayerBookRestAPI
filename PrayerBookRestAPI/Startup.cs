using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrayerBookBLL.Facade;
using PrayerBookBLL.Interfaces;
using PrayerBookBLL.Services;
using PrayerBookDAL.Context;
using PrayerBookDAL.Facade;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.UOW;

namespace PrayerBookRestAPI
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            Environment = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton(Configuration);
            if(Environment.IsDevelopment())
                services.AddDbContext<PrayerBookContext>(opt => opt.UseInMemoryDatabase("PrayerBook"));
            else
            services.AddDbContext<PrayerBookContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IBLLFacade, BLLFacade>();
            services.AddScoped<IDALFacade, DALFacade>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IPrayerService, PrayerService>();
            services.AddScoped<IResponseService, ResponseService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();

                
            }
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            app.UseMvc();

            //app.UseStaticFiles();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller}/{action=Index}/{id?}");
            //});
        }
    }
}
