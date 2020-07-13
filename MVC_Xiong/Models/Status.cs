using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Xiong.Models
{
    public class Status
    {
        public string StatusId { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(25, ErrorMessage ="Name must be 25 characters or less")]
        public string Name { get; set; }

        internal string ToLower()
        {
            throw new NotImplementedException();
        }
    }
}
