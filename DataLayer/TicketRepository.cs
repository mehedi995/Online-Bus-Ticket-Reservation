using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TicketRepository : ITicketRepository
    {
        DataContext db;
        public TicketRepository()
        {
            this.db = new DataContext();
        }
        public int Delete(string id)
        {
            // this.db.Tickets.SingleOrDefault(t => t.TicketNumber == id);
            Ticket deleteTicket = this.db.Tickets.SingleOrDefault(t => t.TicketNumber == id);
             this.db.Tickets.Remove(deleteTicket);
            return this.db.SaveChanges();
        }

        public Ticket Get(string id)
        {
            return this.db.Tickets.SingleOrDefault(t => t.TicketNumber == id);
            
        }

        public List<Ticket> GetAll()
        {
            return this.db.Tickets.ToList();
        }

        public int Insert(Ticket ticket)
        {
            this.db.Tickets.Add(ticket);
            return this.db.SaveChanges();
        }

        public int Update(Ticket ticket)
        {
            Ticket updateTicket = this.db.Tickets.SingleOrDefault(t => t.TicketNumber == ticket.TicketNumber);

            updateTicket.TicketNumber = ticket.TicketNumber;
            updateTicket.DepartureTime = ticket.DepartureTime;
            updateTicket.ArrivalTime = ticket.ArrivalTime;
            updateTicket.Deparature = ticket.Deparature;
            updateTicket.Arrival = ticket.Arrival;
            updateTicket.Rent = ticket.Rent;
            updateTicket.RouteId = ticket.RouteId;

            return db.SaveChanges();
        }
    }
}
