using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Hotel
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Destination")]
        public Guid DestinationId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
