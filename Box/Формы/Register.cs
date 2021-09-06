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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input i = new Input();
            i.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
          
            else if(stringCheck == true)
            {   
                using (SqlConnection connection = new SqlConnection(Input.connectionString))
                {

                    MessageBox.Show("Вы зарегистрировались!");
                    string sql = @"INSERT INTO UserList  VALUES ('" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','Пользователь', '" + comboBox1.Text + "','Москва', '" + maskedTextBox1.Text + "', '"+dateTimePicker1.Value+"')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sql, connection);
                    int number = command1.ExecuteNonQuery();
                    Input i = new Input();
                    i.Show();
                    Close();
                }
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "+0(000)000-00-00";

            pictureBox2.Image = Properties.Resources.лого;
        }
    }
}
