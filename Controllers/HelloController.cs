using System;
using Microsoft.AspNetCore.Mvc;
using login_reg.Models;

namespace login_reg
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("loggedin")]
        public IActionResult Create(User user)
        {
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