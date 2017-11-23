using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Bus_Ticket_Reservation.Controllers
{
    public class AdminController : Controller
    {
        private AdminRepository repo = new AdminRepository();
        // GET: Admin
        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }
    }
}