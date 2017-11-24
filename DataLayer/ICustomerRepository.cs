using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer Get(int id);
        int Insert(Customer customer);
        int Update(Customer customer);
        int Delete(int id);
    }
}
