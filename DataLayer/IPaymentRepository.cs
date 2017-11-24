using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPaymentRepository
    {
        List<Payment> GetAll();
        Payment Get(int id);
        int Insert(Payment payment);
        int Update(Payment payment);
        int Delete(int id);
    }
}
