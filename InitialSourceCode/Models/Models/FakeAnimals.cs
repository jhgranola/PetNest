using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetNestInitial.Models
{
    public class FakeAnimals : Animals
    {
        public IQueryable<Animals> Products => new List<Animals> {
        new Animals { AnimalID = 1,
        AnimalName = "Sparky",
        AnimalAge = 2,
        AnimalType = "Dog",
        AnimalBreed = "Dalmation",
        AnimalSex  = "Male",
        AnimalWeight = 43,
        IsSpayedOrNeutered = "Yes",
        VaccinationUpToDate = "As of 05 Apr 2020",
        AnimalAboutMe = "My name is Sparky and I love cuddles and walks. My bigges priority is checking on my human and keeping them safe.",
        OwnerId = null }
        }.AsQueryable<Animals>();
    }
}
