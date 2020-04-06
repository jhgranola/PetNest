using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class ReportUsers
    {
        public string UserId { get; set; }
        public int? ReportId { get; set; }
        public string ReasonId { get; set; }
        public string ReportResolved { get; set; }
    }
}
