using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    public class Bus
    {
        public int BusNumber { get; set; }
        public string DriverNameAndSurname { get; set; }
        public string RouteNumber { get; set; }
        public bool OnTheRoute { get; set; }
        public Bus(int busNumber, string driverNameAndSurname, string routeNumber, bool onTheRoute)
        {
            BusNumber = busNumber;
            DriverNameAndSurname = driverNameAndSurname;
            RouteNumber = routeNumber;
            OnTheRoute = onTheRoute;
        }
    }
}
