using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculation()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            PrintService printService = new PrintService();

            if (string.IsNullOrEmpty(input_Data.Text))
            {
                errorProvider.SetError(input_Data, "Поле не должно быть пустым");
            }
            else if (int.TryParse(input_Data.Text, out int papersToPrint))
            {
                if (papersToPrint <= 0)
                {
                    errorProvider.SetError(input_Data, "Введите положительное число больше нуля");
                }
                else
                {
                    printService.setPapersToPrint(papersToPrint);
                    double hours = printService.CalculatePrintingTime();
                    double cost = printService.CalculatePrintingCost();
                    result_1.Text = $"{hours}";
                    result_2.Text = $"{cost}";
                }
            }
            else
            {
                errorProvider.SetError(input_Data, "Введите целое число");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculation_1(object sender, EventArgs e)
        {
            Calculation();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileClick(object sender, EventArgs e)
        {

        }

        private void close2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputData(object sender, EventArgs e)
        {

        }

        private void result1(object sender, EventArgs e)
        {

        }

        private void result2(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            input_Data.Clear();
            result_1.Clear();
            result_2.Clear();
        }

        private void calculation_2(object sender, EventArgs e)
        {
            Calculation();
        }

        private void initialData1(object sender, EventArgs e)
        {

        }

        private void initialData2(object sender, EventArgs e)
        {

        }

        private void aboutTheProgramClick(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void reference_Click(object sender, EventArgs e)
        {

        }
    }
}
