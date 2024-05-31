using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public class Bus<T, T2, T3>
    {
        public T BusNumber { get; set; }
        public T2 DriverNameAndSurname { get; set; }
        public T2 RouteNumber { get; set; }
        public T3 OnTheRoute { get; set; }
        public Bus(T busNumber, T2 driverNameAndSurname, T2 routeNumber, T3 onTheRoute)
        {
            BusNumber = busNumber;
            DriverNameAndSurname = driverNameAndSurname;
            RouteNumber = routeNumber;
            OnTheRoute = onTheRoute;
        }
    }
}
