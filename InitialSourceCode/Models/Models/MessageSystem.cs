using System;
using System.Collections.Generic;

namespace PetNestInitial.Models
{
    public partial class MessageSystem
    {
        public string MessageId { get; set; }
        public string Recipient { get; set; }
        public string MessageBody { get; set; }
        public byte[] MessageTimeStamp { get; set; }
        public string ReportUserUserId { get; set; }
    }
}
