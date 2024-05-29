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

        private void button_Russian_Select_Click(object sender, EventArgs e)
        {
            int busNumber = Convert.ToInt32(txtBusNumber.Text);
            string driverName = txtDriverName.Text;
            string routeNumber = txtRouteNumber.Text;
            bool isOnRoute = chkIsOnRoute1.Checked;

            Bus bus = new Bus(busNumber, driverName, routeNumber)
            {
                BusNumber = busNumber,
                DriverName = driverName,
                RouteNumber = routeNumber,
            };

            BusPark busPark = new BusPark();
                busPark.AddBus(bus);

            // Очистка полей ввода после добавления автобуса
            txtBusNumber.Text = "";
            txtDriverName.Text = "";
            txtRouteNumber.Text = "";
            chkIsOnRoute1.Checked = false;
        }
    }
}
