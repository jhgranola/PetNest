using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class Animals
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public int? AnimalAge { get; set; }
        public string AnimalType { get; set; }
        public string AnimalBreed { get; set; }
        public string AnimalSex { get; set; }
        public int? AnimalWeight { get; set; }
        public string IsSpayedOrNeutered { get; set; }
        public string VaccinationUpToDate { get; set; }
        public string AnimalAboutMe { get; set; }
        public int? OwnerId { get; set; }

        public virtual UserProfile Owner { get; set; }
    }
}
