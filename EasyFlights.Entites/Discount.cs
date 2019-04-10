using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Discount
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Price { get; set; }
        public string PassportSerialNumber { get; set; }
    }
}
