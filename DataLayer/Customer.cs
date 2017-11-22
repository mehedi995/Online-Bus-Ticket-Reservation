using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string Address { get; set; }
        [MaxLength(6)]
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public string Email { get; set; }
    }
}
