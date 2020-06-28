using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Xiong.Models
{
    public class Student
    {
        // number needed in input to determine where to route user
    
        public int? Number { get; set; }
        // student name and grade below only needed for admin
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public static void RouteUser()
        {

            int Number = 0;

            /*
            if (Number <= 2)
                //route to view "Two"
            else if (Number > 2 && Number <= 8)
                //route to view "Eight"
            else (Number > 8)
                // route to view "Admin"
                return;
            */

        }
    }
    
    
    

}
