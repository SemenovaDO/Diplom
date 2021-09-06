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
    public partial class EditOrder : Form
    {
        public EditOrder()
        {
            InitializeComponent();
        }
        private void EditOrder_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM OrderList where OrderNumder = '" + ListOrder.Current + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = "" + reader[0].ToString();

                    textBox2.Text = "" + reader[3].ToString();
                    textBox3.Text = "" + reader[4].ToString();

                    textBox4.Text = "" + reader[5].ToString();

                    textBox9.Text = "" + reader[11].ToString();

                    textBox6.Text = "" + reader[6].ToString() + " " + reader[7].ToString() + " " + reader[8].ToString();

                    dateTimePicker1.Text = "" + reader[1].ToString();
                    dateTimePicker2.Text = "" + reader[2].ToString();

                    comboBox1.Text = "" + reader[12].ToString();
                    richTextBox1.Text =  "" + reader[13].ToString();

                }
                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListOrder list = new ListOrder();
            list.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                MessageBox.Show("Данные успешно изменены");
                string sql = @"Update OrderList Set OrderDelivery = '" + dateTimePicker2.Value + "', Status = '" + comboBox1.Text + "' Where OrderNumder = '" + ListOrder.Current + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int number = command.ExecuteNonQuery();
                ListOrder  lo = new ListOrder();
                lo.Show();
                Close();
            }
        }
    }
}
