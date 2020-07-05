using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Models;

namespace MVC_Xiong.Controllers
{
    public class FavoritesController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        

        
        [HttpGet]
        public ViewResult Index()
        {
            
            var session = new FlagSession(HttpContext.Session);
            var model = new FlagViewModel
            {
                ActiveOly = session.GetActiveOly(),
                ActiveCat = session.GetActiveCat(),
                Flags = session.GetMyCountries()
            };
            return View(model);
            

    }
        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new FlagSession(HttpContext.session);
            session.RemoveMyCountries();

            TempData["message"] = "Favorite countries cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveOly = session.GetActiveOly(),
                    ActiveCat = session.GetActiveCat()
                });
        }*/
    }
}
