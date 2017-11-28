using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Route_detailRepository : IRoute_detailRepository
    {
        private DataContext db;

        public Route_detailRepository()
        {
            this.db = new DataContext();
        }
        public int Delete(int id)
        {
            Route_detail deleteRoute = this.db.RouteDetails.SingleOrDefault(r => r.RouteId == id);
            this.db.RouteDetails.Remove(deleteRoute);
            return this.db.SaveChanges();
        }

        public Route_detail Get(int id)
        {
            return this.db.RouteDetails.SingleOrDefault(r => r.RouteId == id);
        }

        public List<Route_detail> GetAll()
        {
            return this.db.RouteDetails.ToList();
        }

        public int Insert(Route_detail route)
        {
            this.db.RouteDetails.Add(route);
            return this.db.SaveChanges();
        }

        public int Update(Route_detail route)
        {
            Route_detail updateRoute = this.db.RouteDetails.SingleOrDefault(r => r.RouteId == route.RouteId);

            updateRoute.RouteId = route.RouteId;
            updateRoute.Deparature = route.Deparature;
            updateRoute.Deparature = route.Deparature;
            updateRoute.Arrival = route.Arrival;
            updateRoute.Rent = route.Rent;
            return this.db.SaveChanges();
        }
    }
}
