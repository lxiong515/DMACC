using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Xiong.Controllers
{
    public class Dummy3Controller : Controller
    {
        //[Route("/")] //This attribute routing shortens the URL for Dummy Page 3. It also overrides the default routing of the Home view
        public IActionResult Index(int ID)
        {
            ViewData["Number"] = (ID); // i;
            return View();
        }
        //[Route("Index/Page")]
        public string Page(int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"This is Dummy Page 3 with a custom attribute. See Dummy3Controller to see routing."); // Enter a number to URL: {ID}");
        }

    }
}
