using EasyFlights.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Contracts
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAllFlights();
    }
}
