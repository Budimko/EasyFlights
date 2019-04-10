using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Type")]
        public Guid TypeId { get; set; }

        public string ColumnNumber { get; set; }
        public string RowNumber { get; set; }
    }
}
