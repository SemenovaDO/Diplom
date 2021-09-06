using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Box
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a_count;
            string a;
            a = textBox5.Text;
            a_count = a.Length;
            bool stringCheck = true;

            if (a_count < 6)
            {
                stringCheck = false;
                MessageBox.Show("Пароль должен содержать не менее 6 символов");
            }
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum = new Regex(@".{8,}");
            var hasSpecialChar = new Regex("[!@#$^.]");
            var isValidated = hasNumber.IsMatch(a) && hasUpperChar.IsMatch(a) && hasMinimum.IsMatch(a) && hasSpecialChar.IsMatch(a);

            if (stringCheck == false)
            {
                MessageBox.Show("Пароль не безопасен");
                stringCheck = false;
            }
            else if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }


            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Вы зaполнили не все данные! Перепроверьте, пожалуйста.");
            }

            else
            {
                using (SqlConnection connection = new SqlConnection(Input.connectionString))
                {
                    MessageBox.Show("Данные успешно изменены");
                    string sql = @"Update UserList Set  Email = '" + textBox4.Text + "', Password = '" + textBox5.Text + "', LastName = '" + textBox1.Text + "', FirstName = '" + textBox2.Text + "', MiddleName = '" + textBox3.Text + "', Gender = '" + comboBox1.Text + "', Number = '" + maskedTextBox1.Text + "', DateOfBirth = '" + dateTimePicker1.Value + "' Where Email = '" + Input.login + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                    Account account = new Account();
                    account.Show();
                    Hide();
                }
            }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "+0(000)000-00-00";

            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM UserList where Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = "" + reader[3];
                    textBox2.Text = "" + reader[4];
                    textBox3.Text = "" + reader[5];
                    textBox4.Text = "" + reader[1];
                    textBox5.Text = "" + reader[2];
                    textBox6.Text = "" + reader[2];
                    maskedTextBox1.Text = "" + reader[9];
                    comboBox1.Text = "" + reader[7];
                    dateTimePicker1.Text = "" + reader[10];

                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }
    }
}
