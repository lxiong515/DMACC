using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Xiong.Controllers
{
    public class Dummy1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
