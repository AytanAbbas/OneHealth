﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class NewsDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
