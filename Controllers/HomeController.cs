using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using logintwo.Models;

namespace logintwo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("loggingin")]
        public IActionResult Login(Logger logger)
        {
            if (ModelState.IsValid) {
                return View("Registered");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("loggedin")]
        public IActionResult Create(User user)
        {
            System.Console.WriteLine("running create");
            if (ModelState.IsValid) {
                return View("Registered");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
