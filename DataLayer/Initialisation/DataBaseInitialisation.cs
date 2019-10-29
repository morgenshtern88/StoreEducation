using DataLayer.AppContext;
using DataLayer.Enteties;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace DataLayer.Initialisation
{
    public class DataBaseInitialisation
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<Role> roleManager;
        private ApplicationContext applicationContext;
        public DataBaseInitialisation(UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager, ApplicationContext applicationContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.applicationContext = applicationContext;

        }
        public void InitialisationRole()
        {
            var role = new List<Role>() {
             new Role { Name = "admin" },
             new Role { Name = "user" }
        };
            foreach(var item in role)
            {
                roleManager.CreateAsync(item).GetAwaiter().GetResult();
            }
        }

        public void InitialisotAuthor()
        {
            var author = new List<Author>()
            {
                new Author {Id =1 ,Name = "Terry Pratchett"}
            };

            foreach (var item in author)
            {
                applicationContext.Authors.Add(item);
            }
        }
    }
}
