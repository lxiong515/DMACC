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
        
        private FlagsContext context;
        
        public OlympicController(FlagsContext ctx)
        {
            context = ctx;
        }
        
        public ViewResult Index(string activeOly = "All", 
            string activeCat = "All")
        {
            var model = new FlagViewModel
            {
                ActiveOly = activeOly,
                ActiveCat = activeCat,
                Games = context.Games.ToList(),
                Sport = context.Sports.ToList()

            };
             
            //get countries - filter by Game and Sport
            //use FlagViewModel instead of flag?
            IQueryable<Countries> query = context.Countries;
            if (activeOly != "all")
                query = query.Where(
                    t => t.Game.Game.ToLower() ==
                    activeOly.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    t => t.Sport.Sport.ToLower() ==
                    activeCat.ToLower());

            // pass teams to view as model
            model.Flags = query.ToList();
            return View(model);
            
        }
        /*
        public ViewResult Index()
        {
            int num = (int)HttpContext.Session.GetInt32("num");
            num += 1;
            HttpContext.Session.SetInt32("num", num);
            return View();
        }
        */
        [HttpPost]
        public RedirectToActionResult Details([FromForm] Countries model)
        {
            //Flag.Country(model.Flags.Count); //need to fix
            //TempData["ActiveOly"] = ActiveOly;
            //TempData["ActiveCat"] = ActiveCat;
            return RedirectToAction("Details", new { id = model.Id});
        }
        [HttpGet]
        public ViewResult Details(int id)
        {
            var model = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .FirstOrDefault(t => t.Id == id);
            /*
        var model = new FlagViewModel {
            Flags = context.Countries
                .Include(t=> t.Game) 
                .Include(t=> t.Sport)
                .FirstOrDefault(t=> t.Id == id),
            ActiveOly = TempData.Peek("ActiveConf").ToString(),
            ActiveCat = TempData.Peek("ActiveDiv").ToString()
            
        }; */
            return View(model);

        }
        /*
        //page 339 Home controller
        public ViewResult Index(string activeOly = "all", string activeCat = "all")
        {
            var session = new FlagSession(HttpContext.Session);
            session.SetActiveOly(activeOly);
            session.SetActiveCat(activeCat);
        }
        */
        
    }
}
