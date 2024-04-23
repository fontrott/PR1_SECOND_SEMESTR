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
            PrintService printService = new PrintService();

            if (int.TryParse(input_Data.Text, out int papersToPrint))
            {
                if (papersToPrint < 0 || papersToPrint == 0)
                {
                    MessageBox.Show("Вы ввели отрицательное или число, равное нулю! Пожалуйста, введите положительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double hours = printService.CalculatePrintingTime(papersToPrint);
                    double cost = printService.CalculatePrintingCost(papersToPrint);
                    result_1.Text = $"{hours} часов";
                    result_2.Text = $"{cost} рублей";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста, введите число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
