using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace wwlp.MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult MainMenu()
        {
            return View();
        }
    }
}