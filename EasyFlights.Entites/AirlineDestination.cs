using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class AirlineDestination
    {
        public Guid Id { get; set; }
        public Guid DestinationId { get; set; }
        public Guid AirlineId { get; set; }
    }
}
