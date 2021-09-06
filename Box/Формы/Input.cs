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
using System.IO;
using System.Data.SqlClient;

namespace Box
{

    public partial class Input : Form
    {
        public static string connectionString = @"Data Source = DESKTOP-MUH5PT0; Initial Catalog = HandicraftBox; Integrated Security = True";
        public static string login, role;
        public Input()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Main i = new Main();
            i.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM UserList WHERE[Email] = '" + textBox1.Text + "'and[Password] = '" + textBox2.Text + "'";
            SqlConnection con = new SqlConnection(Input.connectionString);
            con.Open();
            SqlCommand com = con.CreateCommand();//Создает и возвращает объект SqlCommand, связанный с SqlConnection
            com.CommandText = @"SELECT Role FROM UserList WHERE[Email] = '" + textBox1.Text + "'and[Password] = '" + textBox2.Text + "'";
            SqlDataReader thisReader = com.ExecuteReader();
            string ass = string.Empty;//возвращает пустую строку, статус read only
            while (thisReader.Read())
            {
                ass += thisReader["Role"];
            }
            thisReader.Close();
            con.Close();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connectionString))
            {
                DataTable DT = new DataTable();
                dataAdapter.Fill(DT);//Добавляет или обновляет строки в DataSet для получения соответствия строкам в источнике данных
                if (DT.Rows.Count == 1)//Если находит строку меньше 1, то пароль и логин не найден
                {
                    switch (ass)
                    {
                        case "Пользователь":
                            Main m = new Main();
                            m.Show();
                            Hide(); //скрывает окно
                            role = "Пользователь";
                            break;
                        case "Редактор":
                            MenuEditor ed = new MenuEditor();
                            ed.Show();//показывает форму Редактора
                            Hide();
                            role = "Редактор";
                            break;

                        case "Администратор":
                            Admin a = new Admin();
                            a.Show();
                            Hide();//скрывает окно
                            role = "Администратор";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный пароль или логин! Проверьте правильность введенных данных");
                }
            }

            Input.login = textBox1.Text;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void Input_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._777496_200;
            pictureBox2.Image = Properties.Resources.лого;

            textBox2.UseSystemPasswordChar = true;

        }
    }
}

