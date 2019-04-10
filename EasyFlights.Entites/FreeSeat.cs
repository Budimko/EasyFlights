using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class FreeSeat
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Seat")]
        public Guid SeatId { get; set; }
        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }

        public bool Free { get; set; }
    }
}
