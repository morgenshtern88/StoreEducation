using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataLayer.AppContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DataLayer.Enteties;
using DataLayer.Migrations;
using EducationApp.BusinessLogicLayer;
using DataLayer.Initialisation;

namespace StoreEducation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ApplicationContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

           // services.AddIdentity<ApplicationUser, IdentityRole<long>>()
           //.AddEntityFrameworkStores<ApplicationContext>()
           //.AddDefaultTokenProviders();

            Initial.Initialisator(services, Configuration.GetConnectionString("DefaultConnection"));
            
            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DataBaseInitialisation initialisation)
        {
            initialisation.InitialisationRole();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            
        }
    }
}
