using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class AnimalLocator
    {
        public int? AnimalId { get; set; }
        public int? LocationId { get; set; }
        public int? DateTime { get; set; }

        public virtual Animals Animal { get; set; }
        public virtual Locations Location { get; set; }
    }
}
