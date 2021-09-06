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
    public partial class EditMaterials : Form
    {
        public EditMaterials()
        {
            InitializeComponent();
        }

        private void EditMaterials_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Material where Article = '" + ListMaterials.Current + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = "" + reader[0].ToString();
                    textBox2.Text = "" + reader[1].ToString();
                    textBox3.Text = "" + reader[2].ToString();
                    maskedTextBox1.Text = "" + reader[3].ToString();
                    comboBox1.SelectedItem = "" + reader[4].ToString();
                    comboBox2.SelectedItem =  "" + reader[5].ToString();
                    comboBox3.SelectedItem =  "" + reader[6].ToString();
                    richTextBox1.Text = "" + reader[7].ToString();
                    maskedTextBox2.Text = "" + reader[8].ToString();
                    //if (reader[11].ToString() != "")
                    //{
                    //    pictureBox2.Image = Image.FromFile("Resources/" + reader["Image"]);
                    //}
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListMaterials materials = new ListMaterials();
            materials.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || richTextBox1.Text == "" || maskedTextBox2.Text =="")
            {
                MessageBox.Show("Заполнены не все данные!");

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Input.connectionString))
                {
                    MessageBox.Show("Данные успешно изменены");
                    string sql = @"Update Material Set Title = '" + textBox2.Text + "', Price = '" + textBox3.Text + "', Quantity = '" + maskedTextBox1.Text + "', TypeOfPackaging = '" + comboBox1.Text + "', ProductType = '" + comboBox2.Text + "', Category = '" + comboBox3.Text + "', Structure = '" + richTextBox1.Text + "', Size = '" + maskedTextBox2.Text + "' Where Article = '" + ListMaterials.Current + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int number = command.ExecuteNonQuery();
                    ListMaterials aa = new ListMaterials();
                    aa.Show();
                    Close();
                }
            }
        }
    }

}
