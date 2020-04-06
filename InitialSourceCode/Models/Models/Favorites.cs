using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class Favorites
    {
        public int? UserId { get; set; }
        public int? AnimalId { get; set; }
        public int? FavoriteId { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
