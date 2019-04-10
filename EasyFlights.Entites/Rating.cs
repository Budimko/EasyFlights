using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    class Rating
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FlightId { get; set; }
        public Guid AirlineId { get; set; }
        public string Mark { get; set; }
    }
}
