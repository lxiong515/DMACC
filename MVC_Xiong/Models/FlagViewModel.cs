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
        public List<Countries> Flags { get; set; }
        public string ActiveOly { get; set; }
        public string ActiveCat { get; set; }

        //make next two properties standard properties so the setter can make 
        //the first item in each list "all"
        private List<Games> games;
        public List<Games> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Games { Game = "all" });
            }
        }
        private List<Sports> sport;
        public List<Sports> Sport
        {
            get => sport;
            set
            {
                sport = value;
                sport.Insert(0, new Sports { Sport = "all" });
            }
        }
        //methods to help view determine active link
        public string CheckActiveOly(string c) =>
            c.ToLower() == ActiveOly.ToLower() ? "active" : "";

        public string CheckActiveCat(string d) =>
            d.ToLower() == ActiveCat.ToLower() ? "active" : "";

    }
}
