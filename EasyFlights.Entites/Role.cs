﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFlights.Entites
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        public string Type { get; set; }
    }
}
