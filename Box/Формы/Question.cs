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
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Show();
            Hide();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
            Hide();
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            Hide();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6;
            pictureBox2.Image = Properties.Resources.оплата;
            pictureBox3.Image = Properties.Resources.доставка;
            pictureBox4.Image = Properties.Resources.контакты;
            label15.ForeColor = ColorTranslator.FromHtml("#330035");
            pictureBox5.Image = Properties.Resources.Закрыть;
            pictureBox6.Image = Properties.Resources.Закрыть;
            pictureBox7.Image = Properties.Resources.Закрыть;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            richTextBox3.Visible = true;

            pictureBox6.Visible = false;
            richTextBox1.Visible = false;

            pictureBox7.Visible = false;
            richTextBox2.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            richTextBox3.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox2.Visible = true;

            pictureBox5.Visible = false;
            richTextBox3.Visible = false;

            richTextBox1.Visible = false;
            pictureBox6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            richTextBox2.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;

            pictureBox7.Visible = false;
            richTextBox2.Visible = false;

            pictureBox5.Visible = false;
            richTextBox3.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            richTextBox1.Visible = false;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
