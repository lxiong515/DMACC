using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Xiong.Area.Admin.Controllers
{
    [Area("Admin")]
    public class HelloWorld : Controller
    {
        [Route("[area]/[controller]/{id?}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
