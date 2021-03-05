using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;
using SelfieAWookie.Core.Infrastructure.Selfies;
using SelfieAWookie.Core.Infrastructure.Wookies;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MonSelfieAWookie.Tools;
using MonSelfieAWookie.Models.Dtos;

namespace MonSelfieAWookie
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
            services.AddControllersWithViews();

            ////
            string connectionString = Configuration.GetConnectionString("MaBddDeSelfies");

            services.AddDbContext<SelfieAWookieDbContext>(
                o => o.UseSqlServer(connectionString));

            services.AddCustomDI();

            //Préparation du ioptions
            services.Configure<SecurityItem>(this.Configuration.GetSection("SecurityKey"));
            ////
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Environnement :
            if(env.IsEnvironment("Preprod"))
            {

            }

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseCustomRoutes();
        }
    }
}
