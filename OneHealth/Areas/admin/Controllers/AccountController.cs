﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Areas.admin.Controllers
{[Area("admin")]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
