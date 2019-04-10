using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace EasyFlights.Entites
{
    public class AdditionalService
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Flight")]
        public Guid FlightId { get; set; }

        public string Baggage { get; set; }
        public string Newspaper { get; set; }
        public string Drink { get; set; }
    }
}
