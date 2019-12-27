using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MavToDo.Business.Abstract;
using MavToDo.Business.Concrete;
using MavToDo.DataAccess.Abstract;
using MavToDo.DataAccess.Concrete;
using MavToDo.MVCWebUI.Entities;
using MavToDo.MVCWebUI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MavToDo.MVCWebUI
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
            services.AddMvc();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, CategoryDal>();
            services.AddScoped<IThingsToDoService, ThingsToDoManager>();
            services.AddScoped<IThingsToDoDal, ThingsToDoDal>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<MavIdentityDbContext>(options =>
                options.UseSqlServer("Server=mavzer\\mavzerbay;Database=MavToDo;Integrated Security=SSPI"));
            services.AddIdentity<MavIdentityUser, MavIdentityRole>()
                .AddEntityFrameworkStores<MavIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.AddSession(options =>
            {
                options.IdleTimeout=TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;

                options.Cookie.IsEssential = true;
            });
            services.AddDistributedMemoryCache();
            services.Configure<IdentityOptions>(options =>
             {
                // şifre ile ilgili özellik ayarları
                options.Password.RequireDigit = true;
                 options.Password.RequireLowercase = true;
                 options.Password.RequiredLength = 6;
                 options.Password.RequireNonAlphanumeric = true;
                 options.Password.RequireUppercase = true;

                //şifre yanlış girmelerle ilgili ayarlar
                options.Lockout.MaxFailedAccessAttempts = 3;
                 options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 options.Lockout.AllowedForNewUsers = true;

                //mail ile ilgili ayarlar
                options.User.RequireUniqueEmail = true;

                 options.SignIn.RequireConfirmedEmail = true;
                 options.SignIn.RequireConfirmedPhoneNumber = false;



             });

            // Cookie Configurations

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".AspNetCoreDemo.Account.Cookie",
                    Path = "/",
                    SameSite = SameSiteMode.Lax,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest

                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseAuthentication();
            app.UseFileServer();
            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
