using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class Form1 : Form
    {
        private List<BusInfo> busList;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitBusList()
        {
            busList = new List<BusInfo>
        {
             new BusInfo(Convert.ToInt32(txtBusNumber.Text), txtDriverName.Text, txtRouteNumber.Text, radioBtnOnRoute.Text)
        };
        }
        private void btnAddBus_Click(object sender, EventArgs e)
        {
        }
        private void UpdateBusLocation(int busNumber, bool isOnRoute)
        {
            BusInfo busToUpdate = busList.Find(bus => bus.BusNumber == busNumber);
            if (busToUpdate != null)
            {
                busToUpdate.IsOnRoute = isOnRoute;
                MessageBox.Show($"Информация об автобусе номер {busNumber} обновлена.");
            }
            else
            {
                MessageBox.Show($"Автобус с номером {busNumber} не найден.");
            }
        }
        private List<BusInfo> GetBusesByLocation(bool isOnRoute)
        {
            return busList.FindAll(bus => bus.IsOnRoute == isOnRoute);
        }

        private void btnBusOnRoute_Click(object sender, EventArgs e)
        {
            int busNumber = int.Parse(txtBusNumber.Text);
            UpdateBusLocation(busNumber, true);
        }

        private void btnBusInPark_Click(object sender, EventArgs e)
        {
            int busNumber = int.Parse(txtBusNumber.Text);
            UpdateBusLocation(busNumber, false);
        }

        private void btnGetBusesInPark_Click(object sender, EventArgs e)
        {
            var busesInPark = GetBusesByLocation(false);
            DisplayBusInfo(busesInPark);
        }

        private void btnGetBusesOnRoute_Click(object sender, EventArgs e)
        {
            var busesOnRoute = GetBusesByLocation(true);
            DisplayBusInfo(busesOnRoute);
        }

        private void DisplayBusInfo(List<BusInfo> buses)
        {
            if (buses.Count > 0)
            {
                string busInfo = "Список автобусов:\n";
                foreach (var bus in buses)
                {
                    busInfo += $"Номер: {bus.BusNumber}, Водитель: {bus.DriverName}, Маршрут: {bus.RouteNumber}\n";
                }
                MessageBox.Show(busInfo);
            }
            else
            {
                MessageBox.Show("Нет информации об автобусах.");
            }
        }
    }
}
