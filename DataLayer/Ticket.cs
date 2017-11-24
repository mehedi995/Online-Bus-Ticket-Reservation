using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Ticket
    {
        [Key]
        public string TicketNumber { get; set; }
        
        public DateTime DepartureTime { get; set; }
       
        public DateTime ArrivalTime { get; set; }
        public string Deparature { get; set; }
        public string Arrival { get; set; }
        public double Rent { get; set; }
        public int RouteId { get; set; }
        public Route_detail routeDetail { get; set; }
        public List<Time_Table> Time_Tables { get; set; }

    }
}
