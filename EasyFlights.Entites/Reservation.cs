using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }
        [ForeignKey("FreeSeat")]
        public Guid FreeSeatId { get; set; }
        [ForeignKey("User")]

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportSerialNumber { get; set; }
    }
}
