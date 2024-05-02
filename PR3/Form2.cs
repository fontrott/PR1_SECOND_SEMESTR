using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public partial class AboutTheProgram : Form
    {
        public AboutTheProgram()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void AboutTheProgram_Load(object sender, EventArgs e)
        //{

        //}
    }
}
