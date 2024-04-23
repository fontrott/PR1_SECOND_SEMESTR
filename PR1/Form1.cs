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
        public void FullPayment()
        {
            Class1 printService = new Class1();

            if (int.TryParse(textBox_Date3.Text, out int papersToPrint) && papersToPrint != 0 && papersToPrint > 0)
            {
                double hours = printService.CalculatePrintingTime(papersToPrint);
                double cost = printService.CalculatePrintingCost(papersToPrint);
                textBox_Result.Text = $"{hours} часов";
                textBox1.Text = $"{cost} рублей";
            }
            else
            {
                MessageBox.Show("Введите корректное количество листов для печати!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Date3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox_Date3.Clear();
        }

        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullPayment();
        }

        private void textBox_Date2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Date1_TextChanged(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}
