using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITime_TableRepository
    {
        List<Time_Table> GetAll();
        Time_Table Get(int id);
        int Insert(Time_Table time);
        int Update(Time_Table  time);
        int Delete(int id);
    }
}
