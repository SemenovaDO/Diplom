using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Box
{
    public partial class CatalogMaterials : Form
    {
        public static string article;
        public CatalogMaterials()
        {
            InitializeComponent();
        }

        private void CatalogMaterials_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6;
            pictureBox5.Image = Properties.Resources.рубль;

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Category FROM Category";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }
                connection.Close();
            }
        }
        public  void daan()
        {

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Title FROM Material Where Category = '" + comboBox1.Text + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!comboBox2.Items.Contains(reader["Title"].ToString()))
                    comboBox2.Items.Add(reader["Title"].ToString());
                    }
                    connection.Close();
                }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {

            }

            daan();

        }
        //Загрукзка 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Material where Title = '" + comboBox2.Text + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = "" + reader[0];
                    textBox2.Text = "" + reader[1];
                    textBox3.Text = "" + reader[2];
                    textBox4.Text = "" + reader[4];
                    textBox5.Text = "" + reader[5];
                    textBox6.Text = "" + reader[6];
                    richTextBox1.Text = "" + reader[7];
                    textBox7.Text = "" + reader[8];
                }
                connection.Close();

                using (SqlConnection sqlConnection = new SqlConnection(Input.connectionString))
                {
                    string sql = $"SELECT Image FROM Material Where Article = '" + textBox1.Text + "'";
                    SqlCommand sc = new SqlCommand(sql, sqlConnection);
                    sqlConnection.Open();
                    pictureBox4.Image = Image.FromStream(new MemoryStream((byte[])sc.ExecuteScalar()));
                }
                article = textBox1.Text;
            }
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
            AboutUs us = new AboutUs();
            us.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AddOrder add = new AddOrder();
            add.Show();
            Hide();
        }
    }
}
