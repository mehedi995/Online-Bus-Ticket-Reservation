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
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public string OwnerName { get; set; }
        [Required]
        public string Bank { get; set; }
       
        public int TicketNumber { get; set; }
        public double TotalRent { get; set; }
        public Customer customer { get; set; }
        public Ticket ticket { get; set; }
        public List<Book_detail> BookDetails { get; set; }
    }
}
