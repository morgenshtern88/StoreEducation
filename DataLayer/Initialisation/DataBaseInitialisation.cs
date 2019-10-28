using DataLayer.Enteties;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Initialisation
{
    public class DataBaseInitialisation
    {
        public RoleManager<IdentityRole> RoleManager { get; set; }
        public DataBaseInitialisation(UserManager<ApplicationUser> userManager)
        {

        }
    }
}
