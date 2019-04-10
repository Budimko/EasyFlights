using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Friend
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserSendId { get; set; }
        public Guid UserReceivedId { get; set; }
    }
}
