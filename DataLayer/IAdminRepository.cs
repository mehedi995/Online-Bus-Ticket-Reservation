﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAdminRepository
    {
        List<Admin> GetAll();
        Admin Get(int id);
        int Insert(Admin admin);
        int Update(Admin admin);
        int Delete(int id);
    }
}
