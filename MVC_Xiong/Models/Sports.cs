using System;
using System.Collections.Generic;

namespace MVC_Xiong.Models
{
    public partial class Sports
    {
        public Sports()
        {
            Countries = new HashSet<Countries>();
        }

        public int Id { get; set; }
        public string Sport { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
