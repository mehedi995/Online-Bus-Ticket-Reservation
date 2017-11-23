using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRoute_detailRepository
    {
        List<Route_detail> GetAll();
        Route_detail Get(int id);
        int Insert(Route_detail route);
        int Update(Route_detail route);
        int Delete(int id);
    }
}
