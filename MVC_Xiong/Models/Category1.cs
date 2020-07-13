using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Xiong.Models
{
    public class Category1
    {
        [Required(ErrorMessage = "Please enter a category.")]
        [StringLength(30, ErrorMessage = "Category must be 30 characters or less.")]
        public string CategoryId { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        [StringLength(50, ErrorMessage ="Name must be 50 characters or less.")]
        public string Name { get; set; }
    }
}
