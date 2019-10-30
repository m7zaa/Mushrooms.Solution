﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shrooms.Models;

namespace Shrooms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var mushroomList = Mushroom.MushroomList();
            return View(mushroomList);
        }
    }
}
