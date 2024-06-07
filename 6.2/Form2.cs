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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetVirusName2(string virusName)
        {
            virusName2.Text = virusName;
            virusName2.Text = $"Исследование вируса {virusName} началось.";
        }

        private void virusName2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
