using DataLayer.AppContext;
using DataLayer.Enteties;
using DataLayer.Initialisation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationApp.BusinessLogicLayer
{
    public class Initial
    {
        public static void Initialisator(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentity<ApplicationUser, Role>()
           .AddEntityFrameworkStores<ApplicationContext>()
           .AddDefaultTokenProviders();

            services.AddTransient<UserManager<ApplicationUser>>();
            services.AddTransient<RoleManager<Role>>();
            services.AddTransient<DataBaseInitialisation>();
        }
    }
}
