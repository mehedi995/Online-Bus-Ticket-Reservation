﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Time_Table
    {   [Key]
        public int TimeId { get; set; }
        public int RouteId { get; set; }
        public string Deparature { get; set; }
        public string Arrival { get; set; }
        public string ViaStation { get; set; }
        public DateTime DeparatureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Double Rent { get; set; }
        public Ticket Tickets { get; set; }
        public List<Book_detail> Book_details { get; set; }

    }
}
