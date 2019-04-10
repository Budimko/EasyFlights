using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class AdditionalService
    {
        public Guid Id { get; set; }
        public Guid FlightId { get; set; }
        public string Baggage { get; set; }
        public string Newspaper { get; set; }
        public string Drink { get; set; }
    }
}
