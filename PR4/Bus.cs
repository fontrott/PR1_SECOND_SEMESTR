using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    internal class Bus
    {
        private ListBox busListBox;

        public Bus(ListBox listBox)
        {
            busListBox = listBox;
        }

        public void AddBusToPark(string busNumberInput, string driverNameInput, string routeNumber, bool isOnRoute)
        {
            int busNumber = Convert.ToInt32(busNumberInput);

            Bus newBus = new Bus(busNumber, driverNameInput, routeNumber, isOnRoute);

            string busInfo = $"Bus Number: {newBus.BusNumber}, Driver Name: {newBus.DriverName}, Route: {newBus.RouteNumber}, On Route: {newBus.IsOnRoute}";

            // Добавление информации об автобусе в ListBox
            busListBox.Items.Add(busInfo);
        }
    }
}
