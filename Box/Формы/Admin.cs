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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT FirstName, MiddleName FROM UserList WHERE Email = '" + Input.login + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label2.Text = "Добро пожаловать, " + reader[0] + " " + reader[1];
                }
                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListUser u = new ListUser();
            u.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ListMaterials m = new ListMaterials();
            m.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ListOrder lo = new ListOrder();
            lo.Show();
            Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Input i = new Input();
            i.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListEntry EN = new ListEntry();
            EN.Show();
            Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListMasterClass master_Classes = new ListMasterClass();
            master_Classes.Show();
            Hide();
        }
    }
}
