﻿using Microsoft.AspNetCore.Mvc;

namespace Dia17.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
