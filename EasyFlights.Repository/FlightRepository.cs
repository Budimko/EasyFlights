using EasyFlights.Contracts;
using EasyFlights.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Repository
{
  

    public class FlightRepository : IFlightRepository
    {
        public FlightRepository()
        {

        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return null;// dbcontext.Flight.ToList();
        }
    }
}
