using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void email(object sender, EventArgs e)
        {
        }

        private void CommunicationWithSupportClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void authorName(object sender, EventArgs e)
        {

        }

        private void specialization(object sender, EventArgs e)
        {

        }
    }
}
