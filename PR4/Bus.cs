using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public class Bus<T1, T2, T3, T4>
    {
        public T1 BusNumber { get; set; }
        public T2 DriverNameAndSurname { get; set; }
        public T3 RouteNumber { get; set; }
        public T4 OnTheRoute { get; set; }

        public Bus(T1 busNumber, T2 driverNameAndSurname, T3 routeNumber, T4 onTheRoute)
        {
            BusNumber = busNumber;
            DriverNameAndSurname = driverNameAndSurname;
            RouteNumber = routeNumber;
            OnTheRoute = onTheRoute;
        }

        public static void AddNewBus(List<Bus<T1, T2, T3, T4>> buses, T1 busNumber, T2 driverNameAndSurname, T3 routeNumber, T4 onTheRoute)
        {
            Bus<T1, T2, T3, T4> newBus = new Bus<T1, T2, T3, T4>(busNumber, driverNameAndSurname, routeNumber, onTheRoute);
            buses.Add(newBus);
        }

        public static void UpdateBusInfoTextBox(List<Bus<T1, T2, T3, T4>> buses, TextBox busesTextBox)
        {
            busesTextBox.Clear();
            foreach (Bus<T1, T2, T3, T4> b in buses)
            {
                bool isBusActive = (bool)(object)b.OnTheRoute;
                string status = isBusActive ? "На маршруте" : "В парке";
                string busInfo = $"Номер автобуса: {b.BusNumber}\r\nВодитель: {b.DriverNameAndSurname}\r\nМаршрут: {b.RouteNumber}\r\nСтатус: {status}\r\n";
                busesTextBox.AppendText(busInfo + Environment.NewLine);
            }
        }
    }
}
