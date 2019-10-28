using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Enteties;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace StoreEducation.Controllers
{
    public class AdminController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        public AdminController(UserManager<ApplicationUser> manager)
        {
            _userManager = manager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}