using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Box
{
    public partial class AddGlossary : Form
    {
        public AddGlossary()
        {
            InitializeComponent();
        }

        private void AddGlossary_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM UserList where Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = "" + reader[1];
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || richTextBox1.Text == "")
                {
                    MessageBox.Show("Введите все данные!");
                }
                else
                {
                    MessageBox.Show("Термин добавлен");
                    string sql = @"INSERT INTO Glossary VALUES ('" + textBox1.Text + "', '" + richTextBox1.Text + "', '" + textBox2.Text + "')";
                    using (SqlConnection connection = new SqlConnection(Input.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        int number = command.ExecuteNonQuery();
                    }
                    Glossary glossary = new Glossary();
                    glossary.Show();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так! Повторите попытку позже");
            }

        }

    }
}
