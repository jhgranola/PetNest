using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class Shelters
    {
        public string ShelterName { get; set; }
        public string ShelterDescription { get; set; }
        public int? ShelterPhone { get; set; }
        public int ShelterId { get; set; }
    }
}
