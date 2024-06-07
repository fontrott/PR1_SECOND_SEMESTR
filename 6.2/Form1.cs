using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetVirusName1()
        {
            return virusName1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Начинаем исследование...", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (MessageBox.Show("Ещё чуть-чуть, и мы начнем исследование..") == DialogResult.OK) MessageBox.Show("Начали!");
            }
            Form2 form2 = new Form2();
            form2.SetVirusName2(GetVirusName1());
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены!?", "Предупреждение!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Весь мир погиб из-за вас!", "Wasted", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
         
        public void virusName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
