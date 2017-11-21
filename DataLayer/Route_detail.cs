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
        public int RouteId { get; set;}
        [Required]
        public string Deparature { get; set; }
        [Required]
        public string Arrival { get; set; }
        public string ViaStation { get; set; }
        [Required]
        public double Rent { get; set; }
    }
}
