using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Xml.Linq;

    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
        }
        public void List()
        {
            List<string> list = new List<string>() { "p", "r", "o", "g", "r", "a", "m", "m", "i", "n", "g" };

            list.Reverse();

            if (int.TryParse(textBox1.Text, out int selectedIndex))
            {
                int index = selectedIndex - 1;
                if (index >= 0 && index < list.Count)
                {
                    string selectedElement = list[index];
                    result_1.Text = selectedElement;
                }
                else
                {
                    MessageBox.Show("Индекс выходит за пределы списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculation_button_1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void close_1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void close_2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result_1.Clear();
            textBox1.Clear();
        }

        private void calculation_button_2_Click(object sender, EventArgs e)
        {
            List();
        }

        private void aboutTheProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}
