using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;


namespace Box
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
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

        private void Account_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6;

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM UserList where Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox4.Text = "" + reader[1];
                    textBox2.Text =""+ reader[3];
                    textBox1.Text = "" + reader[4];
                    textBox3.Text = "" + reader[5];
                    dateTimePicker1.Text = "" + reader[10];
                    textBox5.Text = "" + reader[7];
                    textBox6.Text = "" + reader[8];
                    textBox7.Text = "" + reader[9];
                }
                connection.Close();
            }

            if (Input.role == "Администратор")
            {
                button5.Visible = true;
            }
            else if (Input.role == "Редактор")
            {
                button6.Visible = true;
            }

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

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Show();
            Hide();
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Image FROM UserList where Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                connection.Close();
            }
        }

         private void button3_Click(object sender, EventArgs e)
         {
            EditAccount ea = new EditAccount();
            ea.Show();
            Hide();
         }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            Hide();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuEditor ed = new MenuEditor();
            ed.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Story s = new Story();
            s.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrenOrder currenOrder = new CurrenOrder();
            currenOrder.Show();
            Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
