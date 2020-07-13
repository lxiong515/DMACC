using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Xiong.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MVC_Xiong.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            //return Content("Home controller, Index action");
            
        }


        public IActionResult Privacy()
        {
            return View();
            //return Content("Home controller, Privacy action");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //says there already is an index - need diff parameters
        //commented out the other index but then got issues with null on this
        /*
        public ViewResult Index()
        {
            int num = (int)HttpContext.Session.GetInt32("num");
            //added (int) because it wouldnt work
            //InvalidOperationException: Nullable object must have a value
            //going to comment out this 
            num += 1;
            HttpContext.Session.SetInt32("num", num);
            return View();
        }
        */
    }
}
