using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Box
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
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
        private void AboutUs_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6;
            pictureBox2.Image = Properties.Resources.дерево;
            pictureBox3.Image = Properties.Resources.котики;
            pictureBox4.Image = Properties.Resources.кружки;
            pictureBox5.Image = Properties.Resources.лимон;
            pictureBox6.Image = Properties.Resources.свинки;
            pictureBox7.Image = Properties.Resources.куклпа;
            pictureBox8.Image = Properties.Resources.vsim;
            pictureBox9.Image = Properties.Resources.лиса;
            pictureBox10.Image = Properties.Resources.плед;
            pictureBox11.Image = Properties.Resources.совы;
            pictureBox13.Image = Properties.Resources.цветок;
            pictureBox14.Image = Properties.Resources.лошадь; 
            label2.ForeColor = ColorTranslator.FromHtml("#330035");

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT FirstName, MiddleName FROM UserList WHERE Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label2.Text = "Добро пожаловать, " + reader[0] + " " + reader[1];
                }
                connection.Close();
            }
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question g = new Question();
            g.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }
    }
}
