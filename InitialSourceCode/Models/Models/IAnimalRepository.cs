using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetNestInitial.Models
{
    public class IAnimalRepository
    {
        IQueryable<Animals> Products { get; }
    }
}