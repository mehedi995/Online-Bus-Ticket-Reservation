using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        Ticket Get(int id);
        int Insert(Ticket ticket);
        int Update(Ticket ticket);
        int Delete(int id);
    }
}
