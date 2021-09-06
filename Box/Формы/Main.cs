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

    public partial class Main : Form
    {
        public Main()
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
            // Переход на форму "Личный кабинет"

            Account a = new Account();
            a.Show();
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

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._2; // фото для статей
            pictureBox3.Image = Properties.Resources._3; // фото для мастер-классов
            pictureBox1.Image = Properties.Resources._6; // фото для личного кабинета
            pictureBox4.Image = Properties.Resources._4; // фото для личного кабинета

            label3.Parent = pictureBox2;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            label4.Parent = pictureBox3;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            label5.Parent = pictureBox4;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT FirstName, MiddleName FROM UserList WHERE Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label2.Visible = true;
                    label2.Text = "Добро пожаловать, " + reader[0] + " " + reader[1];
                }
                connection.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Переход на форму "Статья"
            
            ListEntry list = new ListEntry(); 
            list.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Переход на форму "Мастер-классов"

            ListMasterClass mc = new ListMasterClass();
            mc.Show();
            Hide();
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Переход на форму "Мастер-классов"

            ListMasterClass mc = new ListMasterClass();
            mc.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Переход на форму "Статья"

            ListEntry list = new ListEntry();
            list.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CatalogMaterials catalog = new CatalogMaterials();
            catalog.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CatalogMaterials catalog = new CatalogMaterials();
            catalog.Show();
            Hide();
        }
    } 
}
