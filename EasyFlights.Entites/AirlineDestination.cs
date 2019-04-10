using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class AirlineDestination
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Destination")]
        public Guid DestinationId { get; set; }
        [ForeignKey("Airline")]
        public Guid AirlineId { get; set; }
    }
}
