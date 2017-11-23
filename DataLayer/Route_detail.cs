using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Route_detail
    {
        [Key]
        public int RouteId { get; set; }
        public string Deparature { get; set; }
        public string Arrival { get; set; }
        public string ViaStation { get; set; }
        public double Rent { get; set; }

        public List<Ticket> Tickets { set; get; }
    }
}
