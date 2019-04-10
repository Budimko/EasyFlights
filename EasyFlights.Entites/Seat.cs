using System;
using System.Collections.Generic;
using System.Text;

namespace EasyFlights.Entites
{
    public class Seat
    {
        public Guid Id { get; set; }
        public Guid TypeId { get; set; }
        public string ColumnNumber { get; set; }
        public string RowNumber { get; set; }
    }
}
