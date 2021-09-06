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
    public partial class Input : Form
    {
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

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //    if (textBox2.UseSystemPasswordChar == true)
        //    {
        //        textBox2.UseSystemPasswordChar = false;
        //    }

        //    else
        //    {
        //        textBox2.UseSystemPasswordChar = true;
        //    }

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Main i = new Main();
            i.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = DESKTOP-MUH5PT0; Initial Catalog = Шкатулка рукоделия; Integrated Security=True";
            string sql = @"SELECT Роль FROM dbo.Пользователь WHERE[Email] = '" + textBox1.Text + "'and[Пароль] = '" + textBox2.Text + "'";
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-MUH5PT0; Initial Catalog = Шкатулка рукоделия; Integrated Security=True");
            con.Open();
            SqlCommand com = con.CreateCommand();//Создает и возвращает объект SqlCommand, связанный с SqlConnection
            com.CommandText = "SELECT Роль FROM dbo.Пользователь WHERE[Email] = '" + textBox1.Text + "'and[Пароль] = '" + textBox2.Text + "'";
            SqlDataReader thisReader = com.ExecuteReader();
            string ass = string.Empty;//возвращает пустую строку, статус read only
            while (thisReader.Read())
            {
                ass += thisReader["Роль"];
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
                            break;
                        case "Редактор":
                            Main m1 = new Main();
                            m1.Show();//показывает форму Кладовщика
                            Hide();
                            break;
                        case "Администратор":
                            Admin a = new Admin();
                            a.Show();
                            Hide();//скрывает окно
                            break;
                    }
                }
                else
                    MessageBox.Show("Неверный пароль или логин! Проверьте правильность введенных данных");
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
         
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }            
        }

        private void Input_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._777496_200;
        }
    }
}

