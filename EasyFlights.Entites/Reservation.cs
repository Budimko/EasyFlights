using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Guid FlightId { get; set; }
        public Guid FreeSeatId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportSerialNumber { get; set; }
    }
}
