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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }
        private void AddOrder_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._6;
            pictureBox2.Image = Properties.Resources.рубль;

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT LastName, FirstName, MiddleName, Email, Number, Article, Price, Quantity FROM UserList, Material where Email = '" + Input.login + "' and Article = '" + CatalogMaterials.article + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox3.Text = "" + reader[0];
                    textBox4.Text = "" + reader[1];
                    textBox5.Text = "" + reader[2];

                    textBox6.Text = "" + reader[3];
                    textBox7.Text = "" + reader[4];

                    textBox1.Text = "" + reader[5];
                    textBox8.Text = "" + reader[6];

                    textBox9.Text = "" + reader[7];
                }
                connection.Close();
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CatalogMaterials materials = new CatalogMaterials();
            materials.Show();
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
            Question question = new Question();
            question.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {  
            // Введенное количество
            string quantity = textBox2.Text;
            int quantity1 = Convert.ToInt32(quantity);

            // Количество на складе 
            string stockquantity = textBox9.Text;
            int stock = Convert.ToInt32(stockquantity);

            //Вычисление остатавшегося количества
            int balance = stock - quantity1;

            textBox10.Text = balance.ToString();

            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы заполнили не все данные!");
            }
            else
            {
                using (SqlConnection connection1 = new SqlConnection(Input.connectionString))
                {
                    string query = @"Update Material Set Quantity = '" + textBox10.Text + "' Where Article = '" + textBox1.Text + "'";
                    connection1.Open();
                    SqlCommand command = new SqlCommand(query, connection1);
                    int number = command.ExecuteNonQuery();
                    connection1.Close();
                }

                using (SqlConnection connection = new SqlConnection(Input.connectionString))
                {
                    MessageBox.Show("Заказ оформлен");
                    string sql = @"INSERT INTO OrderList  VALUES ('" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "','" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "' ,'Москва', '" + textBox7.Text + "', '" + label12.Text + "', 'Оформлен', '" + richTextBox1.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                    CatalogMaterials catalog = new CatalogMaterials();
                    catalog.Show();
                    Hide();
                    Close();
                }


            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox2.Text);
                int stockquantity = Convert.ToInt32(textBox9.Text);

                if (textBox2.Text == "0")
                {
                    MessageBox.Show("Количество не может равняться данному числу!");
                    textBox2.Text = "1";
                }
                else if (quantity > stockquantity)
                {
                    MessageBox.Show("Приносим извинения, но данного количество не имеется в запасе! Введите другое число");
                    textBox2.Text = "1";
                }
                else
                {
                    try
                    {
                        double price = Convert.ToDouble(textBox8.Text);
                        double absoluty = quantity * price;
                        label12.Text = absoluty.ToString() + " рублей";
                        label12.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Введите количество");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Повторите попытку позже!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }
    }
}
