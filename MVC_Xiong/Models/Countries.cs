using System;
using System.Collections.Generic;

namespace MVC_Xiong.Models
{
    public partial class Countries
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public int? GameId { get; set; }
        public int? SportId { get; set; }

        public virtual Games Game { get; set; }
        public virtual Sports Sport { get; set; }
    }
}
