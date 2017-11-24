using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route_detail> RouteDetails { get; set; }
        public DbSet<Time_Table> TimeTables { get; set; }
        public DbSet<Book_detail> BookDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
