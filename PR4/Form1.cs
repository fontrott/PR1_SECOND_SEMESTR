using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class Buses : Form
    {
        List<Bus<int, string, string, bool>> bus = new List<Bus<int, string, string, bool>>();
        ErrorProvider errorProvider = new ErrorProvider();
        public Buses()
        {
            InitializeComponent();
        }
        private void btn_InThePark_Click(object sender, EventArgs e)
        {
            txt_SearchBuses.Clear();
            foreach (Bus<int, string, string, bool> b in bus)
            {
                string busInfo = $"Номер автобуса: {b.BusNumber}\r\nВодитель: {b.DriverNameAndSurname}\r\nМаршрут: {b.RouteNumber}\r\nСтатус: В парке";
                txt_SearchBuses.AppendText(busInfo + "\r\n\r\n");
            }
        }

        private void btn_AddBus_Click(object sender, EventArgs e)
        {
            int busNumber;
            if (!int.TryParse(txt_BusNumber.Text, out busNumber))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер автобуса.");
                return;
            }

            string driverName = txt_DriverNameAndSurname.Text;

            // Используем свойство Checked флажка для получения значения
            bool isNewBus = chk_OnTheRoute.Checked;

            string routeNumber = txt_RouteNumber.Text;

            Bus<int, string, string, bool> newBus = new Bus<int, string, string, bool>(busNumber, driverName, routeNumber, isNewBus);

            MessageBox.Show("Автобус успешно добавлен в список припаркованных автобусов.");
        }
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Close2_Click(object sender, EventArgs e)
        {
            btn_Close1_Click(sender, e);
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_BusNumber.Clear();
            txt_DriverNameAndSurname.Clear();
            txt_RouteNumber.Clear();
            txt_SearchBuses.Clear();
            buses_TextBox.Clear();
            bus.Clear();
        }
        private void btn_AddBus2_Click(object sender, EventArgs e)
        {
            btn_AddBus_Click(sender, e);
        }

        private void aboutTheProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}
