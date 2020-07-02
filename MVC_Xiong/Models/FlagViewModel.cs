using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Xiong.Controllers;
using MVC_Xiong.Data;
using Microsoft.EntityFrameworkCore;

namespace MVC_Xiong.Models
{
    public class FlagViewModel
    {
        public List<Flag> Flags { get; set; }
        public string ActiveOly { get; set; }
        public string ActiveCat { get; set; }

        //make next two properties standard properties so the setter can make 
        //the first item in each list "all"
        private List<Olympic> games;
        public List<Olympic> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Olympic { Game = "all" });
            }
        }
        private List<Category> sport;
        public List<Category> Sport
        {
            get => sport;
            set
            {
                sport = value;
                sport.Insert(0, new Category { Sport = "all" });
            }
        }
        //methods to help view determine active link
        public string CheckActiveOly(string c) =>
            c.ToLower() == ActiveOly.ToLower() ? "active" : "";

        public string CheckActiveCat(string d) =>
            d.ToLower() == ActiveCat.ToLower() ? "active" : "";

    }
}
