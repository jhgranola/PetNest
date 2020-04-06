using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            Animals = new HashSet<Animals>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? UserAge { get; set; }
        public string UserGender { get; set; }
        public string AboutMe { get; set; }
        public string PictureUrl { get; set; }
        public int? MaxDistance { get; set; }
        public string LocationId { get; set; }

        public virtual ICollection<Animals> Animals { get; set; }
    }
}
