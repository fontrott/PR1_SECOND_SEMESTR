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
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            int busNumber = Convert.ToInt32(txtBusNumber.Text);
            string driverName = txtDriverName.Text;
            string routeNumber = txtRouteNumber.Text;
            bool isOnRoute = chkIsOnRoute1.Checked;
            Bus bus = new Bus(busNumber, driverName, routeNumber, isOnRoute)
            {
                BusNumber = busNumber,
                DriverName = driverName,
                RouteNumber = routeNumber,
                IsOnRoute = isOnRoute
            };
            BusPark busPark = new BusPark();
            busPark.AddBus(bus);
            string busss = bus.AddBusToPark(busNumber, driverName, routeNumber, isOnRoute);
            //очистка полей после добавления
            txtBusNumber.Text = "";
            txtDriverName.Text = "";
            txtRouteNumber.Text = "";
            chkIsOnRoute1.Checked = false;
        }
        private void close_1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}