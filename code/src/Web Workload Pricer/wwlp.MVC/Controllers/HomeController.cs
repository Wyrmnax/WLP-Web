using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wwlp.MVC.ViewModels.UI;

namespace wwlp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private HomeUI UI { get; set; }

        public HomeController()
        {
            UI = new HomeUI();
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            ViewData["Message"] = "Esta é a view inicial";
            return View(UI);
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Sobre";
            ViewData["Message"] = "Ésta é a view de about";
            return View(UI);
        }
    }
}
