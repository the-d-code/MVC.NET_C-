using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyExample.Models;
using static DependencyExample.Service.MyService;

namespace DependencyExample.Controllers
{
    public class HomeController : Controller
    {
        IHelloWorlService hws;
        public HomeController(IHelloWorlService hw)
        {
            hws = hw;
        }
        public IActionResult Index()
        {
            ViewData["MyText"] = hws.SayHello() ;
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
