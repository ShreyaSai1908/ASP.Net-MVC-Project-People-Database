using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_All_Assignments.Models.Database;
using Database_All_Assignments.Models.Identity;
using Database_All_Assignments.Models.Repositorys;
using Database_All_Assignments.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Database_All_Assignments
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
            services.AddIdentity<ContentUser, IdentityRole>()
            .AddEntityFrameworkStores<IdentityContentDbContext>()
            .AddDefaultTokenProviders();

            services.AddDbContext<IdentityContentDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            /*People Service*/
            services.AddScoped<IPeopleServices, PeopleService>(); //Container setting for IoC
            //services.AddScoped<IPeopleRepo, InMemoryPeopleRepo>(); //Container setting for IoC
            services.AddScoped<IPeopleRepo, DatabasePeopleRepo>(); //Container setting for IoC

            /*City Service*/
            services.AddScoped<ICityService, CityService>(); //Container setting for IoC
            //services.AddScoped<ICityRepo, InMemoryCityRepo>(); //Container setting for IoC
            services.AddScoped<ICityRepo, DatabaseCityRepo>(); //Container setting for IoC

            /*City Service*/
            services.AddScoped<ICountryService, CountryService>(); //Container setting for IoC
            //services.AddScoped<ICountryRepo, InMemoryCountryRepo>(); //Container setting for IoC
            services.AddScoped<ICountryRepo, DatabaseCountryRepo>(); //Container setting for IoC
            
            /*Language Service*/
            services.AddScoped<ILanguageService, LanguageService>(); //Container setting for IoC
            //services.AddScoped<ICountryRepo, InMemoryCountryRepo>(); //Container setting for IoC
            services.AddScoped<ILanguageRepo, DatabaseLanguageRepo>(); //Container setting for IoC

            /*PersonLanguage Service*/
            services.AddScoped<IPersonLanguageService, PersonLanguageService>(); //Container setting for IoC
            //services.AddScoped<IPersonLanguageRepo, InMemoryPersonLanguageRepo>(); //Container setting for IoC
            services.AddScoped<IPersonLangRepo, DatabasePersonLangRepo>(); //Container setting for IoC

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseAuthentication(); //User login??
            app.UseAuthorization(); //User role??

            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");*/

                endpoints.MapControllerRoute(
                     name: "Route_1",
                     pattern: "{controller}/{action}/{id?}",
                     defaults: new { controller = "People", action = "Add_View_People" });
            });
        }
    }
}
