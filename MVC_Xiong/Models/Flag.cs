using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Controllers;
using MVC_Xiong.Data;
using MVC_Xiong.Models;

namespace MVC_Xiong.Models
{
    public class Flag
    {
        public string Country { get; set; }
    }
    public class Olympic
    {
        public string Game { get; set; }
    }
    public class Category
    {
        public string Sport { get; set; }
    }
}
