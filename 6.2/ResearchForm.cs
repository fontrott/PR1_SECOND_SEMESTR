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
    public partial class ResearchForm : Form
    {
        public ResearchForm()
        {
            InitializeComponent();
        }

        private void virusName2_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_VirusName.Parent = pictureBox1;
            lbl_VirusName.BackColor = Color.Transparent;
            lbl_VirusInfectionCount.Parent = pictureBox1;
            lbl_VirusInfectionCount.BackColor = Color.Transparent;
            lbl_RateInfectrion.Parent = pictureBox1;
            lbl_RateInfectrion.BackColor = Color.Transparent;
        }
        public void StopResearch()
        {
            if (MessageBox.Show("Вы уверены, что хотите прекратить исследование?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Зря вы это сделали...", "Wasted", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
        private void btn_StopResearch2_Click(object sender, EventArgs e)
        {
            StopResearch();
        }

        private void btn_ContinueResearch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хм.. Нам кажется, что недостаточно данных.", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                txt_VirusName1.Visible = true;
                txt_VirusInfectionCount.Visible = true;
                txt_RateInfection.Visible = true;
                lbl_RateInfectrion.Visible = true;
                btn_ContinueResearch.Visible = false;
                btn_ContinueResearch2.Visible = true;
            }
        }

        private void lbl_VirusName_Click(object sender, EventArgs e)
        {

        }

        private void btn_ContinueResearch2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Пожалуй, этих данных должно хватить!", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                txt_VirusName1.Visible = false;
                txt_VirusInfectionCount.Visible = false;
                txt_RateInfection.Visible = false;
                lbl_RateInfectrion.Visible = false;
                lbl_VirusName.Visible = false;
                lbl_VirusInfectionCount.Visible = false;
                btn_ContinueResearch.Visible = false;
                btn_ContinueResearch2.Visible = false;
                txt_VirusType.Visible = true;
            }
            string virusInfectionCount = txt_VirusInfectionCount.Text;
            string rateInfection = txt_RateInfection.Text;
            string virusName = txt_VirusName1.Text; 
            VirusFacade researchCenter = new VirusFacade();
            string virusType = researchCenter.DetermineVirusType(virusInfectionCount, rateInfection, virusName);
            txt_VirusType.Text = virusType;
        }
    }
}
