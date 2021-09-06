using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input i = new Input();
            i.Show();
            Hide();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
            Hide();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            Hide();
        }
    }
}
