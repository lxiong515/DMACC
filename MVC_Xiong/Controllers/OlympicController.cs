using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Controllers;
using MVC_Xiong.Data;
using MVC_Xiong.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MVC_Xiong.Controllers
{
    public class OlympicController : Controller
    {
        
        private FlagContext context;
        
        public OlympicController(FlagContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeOly = "all", 
            string activeCat = "all")
        {
            var model = new FlagViewModel
            {
                ActiveOly = activeOly,
                ActiveCat = activeCat,
                Games = context.Game.ToList(),
                Sport = context.Sport.ToList()

            };
             
            //get countries - filter by Olympic and Category
            //use FlagViewModel instead of flag?
            IQueryable<Flag> query = context.Country;
            if (activeOly != "all")
                query = query.Where(
                    t => t.Country.ToLower() ==
                    activeOly.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    t => t.Country.ToLower() ==
                    activeCat.ToLower());

            // pass teams to view as model
            model.Flags = query.ToList();
            return View(model);
            
        }
        public ViewResult Index()
        {
            int num = (int)HttpContext.Session.GetInt32("num");
            num += 1;
            HttpContext.Session.SetInt32("num", num);
            return View();
        }
        
        [HttpPost]
        public RedirectToActionResult Details(FlagViewModel model)
        {
           // Flag.Country(model.Flags.Count); need to fix
            TempData["ActiveOly"] = model.ActiveOly;
            TempData["ActiveCat"] = model.ActiveCat;
            return RedirectToAction("Details", new { ID = model.Flags});
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
        var model = new FlagViewModel {
            //Flags = context.Country
                //.Include(t=> t.Olympic) need to fix
               // .Include(t=> t.Category)
               // .FirstOrDefault(t=> t.FlagID == id),
            ActiveOly = TempData.Peek("ActiveConf").ToString(),
            ActiveCat = TempData.Peek("ActiveDiv").ToString()
        };
        return View(model);
        }
        
    }
}
