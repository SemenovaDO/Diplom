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
    public partial class UserListAdd : Form
    {
        public UserListAdd()
        {
            InitializeComponent();
        }

        private void UserListAdd_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "+0(000)000-00-00";


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
            else if (textBox2.Text != textBox7.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }

            else if (stringCheck == true)
            {
                MessageBox.Show("Вы зарегистрировались");
                string sql = @"INSERT INTO UserList  VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', 'Редактор' ,'" + comboBox1.Text + "','Москва','" + maskedTextBox1.Text + "','" + dateTimePicker1.Value + "')";                
                using (SqlConnection connection = new SqlConnection(Input.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                }
                ListUser ul = new ListUser();
                ul.Show();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListUser list = new ListUser();
            list.Show();
            Hide();
        }
    }
}
