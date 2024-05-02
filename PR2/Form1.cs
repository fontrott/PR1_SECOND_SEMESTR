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
    public partial class Form1 : Form
    {
        List<string> lists = new List<string>();
        ErrorProvider errorProvider1 = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }
        public async void List()
        {
            try
            {

                lists.Reverse();
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider1.SetError(textBox1, "Поле не должно быть пустым!");
                    await Task.Delay(2000);
                    errorProvider1.SetError(textBox1, "");
                }
                else if (int.TryParse(textBox1.Text, out int selectedIndex))
                {
                    int index = selectedIndex - 1;
                    if (index >= 0 && index < lists.Count)
                    {
                        string selectedElement = lists[index];
                        result_1.Text = selectedElement;
                    }
                    else
                    {
                        errorProvider1.SetError(textBox1, "Некорректный ввод!");
                        await Task.Delay(2000);
                        errorProvider1.SetError(textBox1, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Введите целочисленное значение!");
                    await Task.Delay(2000);
                    errorProvider1.SetError(textBox1, "");
                }
                lists.Reverse();
            }
            catch (FormatException ex) { MessageBox.Show(ex.Message); }
            //List<string> list = new List<string>();

            //list.Reverse();

            //if (int.TryParse(textBox1.Text, out int selectedIndex))
            //{
            //    int index = selectedIndex - 1;
            //    if (index >= 0 && index < list.Count)
            //    {
            //        string selectedElement = list[index];
            //        result_1.Text = selectedElement;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Индекс выходит за пределы списка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Некорректный ввод!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            lists.Clear();
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

        private void input_Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string symbols = input_Data.Text;
            if (!string.IsNullOrEmpty(input_Data.Text))
            {
                lists.Add(symbols);
                input_Data.Clear();
            }
            else
            {
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(input_Data, "Строка пустая");
                await Task.Delay(2000);
                errorProvider1.SetError(input_Data, "");
            }
            string symbols1 = String.Join(", ", lists.Select(n => n.ToString()));
            ReadyList.Text = symbols1;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Введено неправильно, вводите по 1 значению. " + fe.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Упс... что-то пошло не так " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_ReadyList(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
