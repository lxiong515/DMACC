using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Xiong.Controllers
{
    public class Dummy2Controller : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }
    }
}
