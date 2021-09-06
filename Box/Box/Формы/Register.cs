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
           
            else if (stringCheck == true)
            {
                MessageBox.Show("Вы зарегистрировались");
                string connectionString = @"Data Source = DESKTOP-MUH5PT0; Initial Catalog = Шкатулка рукоделия; Integrated Security=True";
                string sql = @"INSERT INTO dbo.Пользователь  VALUES ('" + textBox4.Text + "', '" + textBox5.Text + "','"+ textBox1.Text +"', '"+ textBox2.Text+"','"+textBox3.Text+"' , 'Пользователь' ,'  )";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                }
                Input i = new Input();
                i.Show();
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
