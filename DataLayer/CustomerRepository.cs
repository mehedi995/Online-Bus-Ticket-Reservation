using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private DataContext db;
        public CustomerRepository()
        {
            this.db = new DataContext();
        }
        public int Delete(int id)
        {
            Customer deleteCustomer = this.db.Customers.SingleOrDefault(d => d.CustomerId == id);
            db.Customers.Remove(deleteCustomer);
            return this.db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return this.db.Customers.SingleOrDefault(c => c.CustomerId == id);
        }

        public List<Customer> GetAll()
        {
            return this.db.Customers.ToList();
        }

        public int Insert(Customer customer)
        {
            this.db.Customers.Add(customer);
            return this.db.SaveChanges();
        }

        public int Update(Customer customer)
        {
            Customer updateCustomer = this.db.Customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);

            updateCustomer.CustomerId = customer.CustomerId;
            updateCustomer.Name = customer.Name;
            updateCustomer.Password = customer.Password;
            updateCustomer.Address = customer.Address;
            updateCustomer.Gender = customer.Gender;
            updateCustomer.DateOfBirth = customer.DateOfBirth;
            updateCustomer.ContactNo = customer.ContactNo;
            updateCustomer.Email = customer.Email;

            return this.db.SaveChanges();
        }
    }
}
