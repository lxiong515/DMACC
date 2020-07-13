using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Xiong.Data;
using MVC_Xiong.Models;
using MVC_Xiong.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using System.ComponentModel.DataAnnotations;

namespace MVC_Xiong.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            filterstring = filterstring ?? "all-all-all";
            string[] filters = filterstring.Split('-');
            CategoryId = filters[0];
            DueDate = filters[1];
            StatusId = filters[2];
        }
        [Required(ErrorMessage = "Please enter info.")]
        public string FilterString { get; }
        public string CategoryId { get; }
        [Required(ErrorMessage = "Please enter date.")]
        public string DueDate { get; }
        public string StatusId { get; }

        public bool HasCategory => CategoryId.ToLower() != "all";
        public bool HasDue => DueDate.ToLower() != "all";
        public bool HasStatus => StatusId.ToLower() != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string>
            {
                { "future", "Future" },
                { "past", "Past" },
                { "today", "Today" }
            };
        public bool IsPast => DueDate.ToLower() == "past";
        public bool IsFuture => DueDate.ToLower() == "future";
        public bool IsToday => DueDate.ToLower() == "today";
    }
}
