using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdminRepository : IAdminRepository
    {
        private DataContext db;

        public AdminRepository()
        { this.db = new DataContext(); }

        public List<Admin> GetAll()
        {
            return this.db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return this.db.Admins.SingleOrDefault(d => d.AdminId == id);
        }


        public int Insert(Admin admin)
        {
            this.db.Admins.Add(admin);
            return this.db.SaveChanges();
        }

        public int Update(Admin admin)
        {
            Admin updateAdmin = this.db.Admins.SingleOrDefault(d => d.AdminId == admin.AdminId);
            updateAdmin.Username = admin.Username;
            updateAdmin.Password = admin.Password;
            updateAdmin.Email = admin.Email;

            return this.db.SaveChanges();
        }
        public int Delete(int id)
        {
            Admin AdminToDelete = this.db.Admins.SingleOrDefault(d => d.AdminId == id);
            this.db.Admins.Remove(AdminToDelete);
            return this.db.SaveChanges();
        }

    }
}
