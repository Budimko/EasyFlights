using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class RentaCar
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Destination")]
        public Guid DestinationId { get; set; }

        public string Car { get; set; }
    }
}
