using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Controllers;
using MVC_Xiong.Data;
using MVC_Xiong.Models;

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
            /* need to fix this
             
            //get countries - filter by Olympic and Category
            IQueryable<Flag> query = context.Country;
            if (activeOly != "all")
                query = query.Where(
                    t => t.Olympic.Game.ToLower() ==
                    activeOly.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    t => t.Category.Sport.ToLower() ==
                    activeCat.ToLower());

            // pass teams to view as model
            model.Country = query.ToList();
            */
            return View(model);
            
        }
        
    }
}
