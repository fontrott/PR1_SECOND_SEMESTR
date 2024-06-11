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
    public partial class StartResearchForm : Form
    {
        public StartResearchForm()
        {
            InitializeComponent();
        }
        public void StartResearch()
        {
            Random rnd = new Random();
            int eventNumber = rnd.Next(1, 3);
            switch (eventNumber)
            {
                case 1:
                    if (MessageBox.Show("Начинаем исследование...", "", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        if (MessageBox.Show("Ещё чуть-чуть, и мы начнем исследование..") == DialogResult.OK) MessageBox.Show("Начали!");
                    }
                    ResearchForm form2 = new ResearchForm();
                    form2.Show();
                    this.Hide();
                    break;
                case 2:
                    MessageBox.Show("Вирус оказался слишком смертелен!");
                    Application.Exit();
                    break;
            }
        }
        public void StopResearch()
        {
            if (MessageBox.Show("Вы уверены!?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Весь мир погиб...", "Wasted", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_StartResearch1_Click(object sender, EventArgs e)
        {
            StartResearch();
        }
        private void btn_StopResearch1_Click(object sender, EventArgs e)
        {
            StopResearch();
        }
    }
}
