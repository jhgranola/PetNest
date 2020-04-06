using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string St { get; set; }
    }
}
