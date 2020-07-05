using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Xiong.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using MVC_Xiong.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using MVC_Xiong.Controllers;

namespace MVC_Xiong
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
            // must be called before AddControllerWithViews()
            services.AddMemoryCache();
            services.AddSession(options =>
            {
                //change idle time out to 5 minutes - default is 20 minutes
                options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
                options.Cookie.HttpOnly = false; //default is true
                options.Cookie.IsEssential = true; //default is false
            });

            // mvc services
            services.AddControllersWithViews().AddNewtonsoftJson(); 

            // add other services here.

            services.AddDbContext<MvcMovieContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext"))); ;

            services.AddDbContext<ContactsContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ContactsContext")));

            services.AddDbContext<StudentContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("StudentContext")));

            // olympic app - fixes

            //services.AddScoped<FlagContext, FlagContext>();

            services.AddDbContext<FlagsContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("FlagContext")));


            //services.AddMvc();
            // services.AddDbContext<FlagContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /**
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            **/
            //must be called before useEndPoints() for olympic web app
            app.UseSession();

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();  // mark where routing decisions are made

            app.UseAuthorization();

            // configure middleware that runs after routing decisions have been made

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "custom",
                    pattern: "{controller}/{action}/conf/{activeConf}/div/{activeDiv}");
                // endpoints.MapControllers(); // endpoint for Dummy Page #3
                //(name: "dummy3",
                // pattern: "Dummy3/",
                // defaults: new { controller = "Dummy3", action = "Index", id = "page" });

                // 1. default routing
                // Nothing needed, uses default below.

                // 2. custom routing rules for Dummy Page #2
                endpoints.MapControllerRoute(name: "dummy2",
                     pattern: "Dummy2/",
                     defaults: new { controller = "Dummy2", action = "Index2" });

                //endpoints.MapControllerRoute(
                //    name: "contactApp",
                //    pattern: "{controller=Contacts}/{action=Index}/{id?}");

                //endpoints.MapControllerRoute(
                //    name: "movieApp",
                //    pattern: "{controller=Movies}/{action=Index}/{id?}");

               // endpoints.MapControllerRoute(
                   // name: "twoBelow",
                   // pattern: "two/",
                   // defaults: new { controller = "Assignment", action = "Index" });
                /*
                 * end point for my "Assignment6.1"
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Assignment}/{action=Index}/{id?}");
                */

            endpoints.MapAreaControllerRoute(
                    name: "admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller = Olympic}/{ action = Index}/{ id ?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // configure other middleware here
        }
        
    }
}
