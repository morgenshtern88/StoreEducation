﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreEducation.Controllers.Base
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}