using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Xiong.Models
{
    public class Movie
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

    }
}
