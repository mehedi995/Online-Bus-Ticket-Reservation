using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        Ticket Get(string id);
        int Insert(Ticket ticket);
        int Update(Ticket ticket);
        int Delete(string id);
    }
}
