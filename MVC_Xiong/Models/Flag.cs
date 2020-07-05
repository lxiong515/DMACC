using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVC_Xiong.Controllers;
using MVC_Xiong.Data;
using MVC_Xiong.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Xiong.Models
{
    public class Flag
    {
        [Key]
        public int ID { get; set; }

        public string Country { get; set; }
    }
    public class Olympic
    {
        [Key]
        public int ID { get; set; }
        public string Game { get; set; }
    }
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Sport { get; set; }
    }
}
