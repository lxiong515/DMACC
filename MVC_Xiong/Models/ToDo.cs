using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MVC_Xiong.Data;
using MVC_Xiong.Controllers;
using MVC_Xiong.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC_Xiong.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(150, ErrorMessage = "Please enter details in 150 characters or less.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }
        public Category1 Category { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }

        public bool Overdue =>
            Status?.ToLower() == "open" && DueDate < DateTime.Today;
    }

}
