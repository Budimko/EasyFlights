using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Discount
    {
        public Guid Id { get; set; }
        public Guid FlightId { get; set; }
        public Guid UserId { get; set; }
        public Guid SeatId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Price { get; set; }
        public string PassportSerialNumber { get; set; }
    }
}
