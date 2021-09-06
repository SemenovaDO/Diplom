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
    public partial class MenuEditor : Form
    {
        public MenuEditor()
        {
            InitializeComponent();
        }
        private void MenuEditor_Load(object sender, EventArgs e)
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
        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input i = new Input();
            i.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListEntry  list= new ListEntry();
            list.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListMasterClass master_Classes = new ListMasterClass();
            master_Classes.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Glossary glossary = new Glossary();
            glossary.Show();
            Hide();
        }
    }
}
