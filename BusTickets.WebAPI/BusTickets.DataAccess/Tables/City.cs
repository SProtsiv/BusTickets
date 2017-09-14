﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BusTickets.DataAccess
{
    public class City
    {
        [Key]
        public int ID { get; set; }

        [NotMapped]
        public string Name { get; set; }

        [NotMapped]
        public int People { get; set; }
    }
}
