﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class Book_detail
    {
        public int SeatNo { get; set; }
        public int RouteId { get; set; }
        public DateTime JourneyDate { get; set; }
        public DateTime BookingDate { get; set; }
        public double  Rent { get; set; }
        public string BusType { get; set; }
        public string  Choice { get; set; }

        [ForeignKey("RouteId")]
        public Route_detail RouteDetail { get; set; }
        public Time_Table TimeTables { get; set; }
        public List<Payment> Payments { get; set; }


    }
}