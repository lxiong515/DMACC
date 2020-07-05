using System;
using System.Collections.Generic;

namespace MVC_Xiong.Models
{
    public partial class Games
    {
        public Games()
        {
            Countries = new HashSet<Countries>();
        }

        public int Id { get; set; }
        public string Game { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
