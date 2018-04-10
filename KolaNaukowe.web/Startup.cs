using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using KolaNaukowe.web.Data;
using KolaNaukowe.web.Models;
using KolaNaukowe.web.Services;
using KolaNaukowe.web.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace KolaNaukowe.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Enviroment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Enviroment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, ResearchGroupLeaderAuthorizationHandler>();
            services.AddSingleton<IAuthorizationHandler, ResearchGroupAdminAuthorizationHandler>();

            services.AddScoped<IStudentResearchGroupService, StudentResearchGroupService>();
            services.AddDbContext<KolaNaukoweDbContext>(o => o.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KolaNaukowe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<KolaNaukoweDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();

            //var skipHTPPS = Configuration.GetValue<bool>("LocalTest:skipHTTPS");
            //services.Configure<MvcOptions>(options =>
            //{
            //    if (Enviroment.IsDevelopment() && !skipHTPPS)
            //    {
            //        options.Filters.Add(new RequireHttpsAttribute());
            //    }
            //});

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
