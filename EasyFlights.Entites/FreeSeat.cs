using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class FreeSeat
    {
        public Guid Id { get; set; }
        public Guid SeatId { get; set; }
        public Guid FlightId { get; set; }
        public bool Free { get; set; }
    }
}
