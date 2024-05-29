using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public class Bus
    {
        private ListBox busListBox;

        public Bus(ListBox listBox)
        {
            busListBox = listBox;
        }
        public int BusNumber { get; set; }
        public string DriverName { get; set; }
        public string RouteNumber { get; set; }
        public bool IsOnRoute { get; set; }
        public Bus(int busNumber, string driverName, string routeNumber, bool isOnRoute)
        {
            BusNumber = busNumber;
            DriverName = driverName;
            RouteNumber = routeNumber;
            IsOnRoute = isOnRoute;
            AddBusToPark();
        }
        public void AddBusToPark(int busNumberInput, string driverNameInput, string routeNumber, bool isOnRoute)
        {
            int busNumber = busNumberInput;
            Bus newBus = new Bus(busNumberInput, driverNameInput, routeNumber, isOnRoute);
            string busInfo = $"Bus Number: {newBus.BusNumber}, Driver Name: {newBus.DriverName}, Route: {newBus.RouteNumber}, On Route: {newBus.IsOnRoute}";
            busListBox.Items.Add(busInfo);
            busListBox.Text = busInfo;
        }
    }
}
