using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Flight
    {
        public Guid Id { get; set; }
        public Guid AirlineId { get; set; }
        public Guid DestinationIdFrom { get; set; }
        public Guid DestinationIdTo { get; set; }
        public Guid AirplainId { get; set; }
        public Guid TypeId { get; set; }
        public string Distance { get; set; }
        public DateTime DateAndTimeOfDeparture { get; set; }
        public DateTime DateAndTimeOfLanding { get; set; }
        public TimeSpan? TimeOfTrevel { get; set; }
        public decimal Price { get; set; }
    }
}
