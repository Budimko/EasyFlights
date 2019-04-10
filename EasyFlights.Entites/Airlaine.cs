using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Airlaine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
    }
}
