using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Bus_Ticket_Reservation.Startup))]
namespace Online_Bus_Ticket_Reservation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
