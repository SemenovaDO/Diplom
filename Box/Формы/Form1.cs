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

namespace Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.рубль;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Выберите фото аттестата";
            //ofd.InitialDirectory = @"D:\Приемка";
            //ofd.Filter = "Файлы JPG, GIF, PNG|*.jpg;*.gif;*.png|Все файлы (*.*)|*.*";
            //DialogResult rc = ofd.ShowDialog();
            //if (rc == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(ofd.FileName);
            //}


        }
        private SqlConnection GetConnectioin()
        {
            return new SqlConnection(Input.connectionString);
        }
        public void InsertRecord()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Выберите фото аттестата";
                ofd.InitialDirectory = @"D:\Приемка";
                ofd.Filter = "Файлы JPG, GIF, PNG|*.jpg;*.gif;*.png|Все файлы (*.*)|*.*";
                DialogResult rc = ofd.ShowDialog();
                if (rc == DialogResult.OK)
                {
                    SqlConnection sqlConnection = new SqlConnection(Input.connectionString);
                    string query = $"Insert into Material (Article,Title,Price,Quantity,TypeOfPackaging , ProductType, Category, Structure, Size) " +
                        $"Values (@Article, @Title, @Price, @Quantity, @TypeOfPackaging , @ProductType, @Category, @Structure, @Size)";

                    using (SqlConnection cb = GetConnectioin())
                    {
                        SqlCommand cmd = new SqlCommand(query, cb);
                        cmd.Parameters.Add("@Article", SqlDbType.VarChar, 100).Value = maskedTextBox1.Text;
                        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = textBox6.Text;
                        cmd.Parameters.Add("@Price", SqlDbType.VarChar, 50).Value = textBox5.Text;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = textBox4.Text;
                        cmd.Parameters.Add("@TypeOfPackaging", SqlDbType.VarChar, 50).Value = comboBox1.SelectedItem;
                        cmd.Parameters.Add("@ProductType", SqlDbType.VarChar, 50).Value = comboBox3.SelectedItem;
                        cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = comboBox2.SelectedItem;
                        cmd.Parameters.Add("@Structure", SqlDbType.VarChar).Value = richTextBox1.Text;
                        cmd.Parameters.Add("@Size", SqlDbType.VarChar, 10).Value = textBox7.Text;
                        cb.Open();
                        cmd.ExecuteNonQuery();
                    }
                    SqlConnection sqlConnection1 = new SqlConnection(Input.connectionString);
                    SqlCommand sqlCommand = new SqlCommand($"Update  Material   Set  Image = @img where Article = '" + maskedTextBox1.Text + "'", sqlConnection1);
                    SqlParameter sqlParameter = new SqlParameter("@img", SqlDbType.VarBinary);
                    Image image = Image.FromFile(ofd.FileName);
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                    sqlParameter.Value = memoryStream.ToArray();
                    sqlCommand.Parameters.Add(sqlParameter);
                    sqlConnection1.Open();
                    sqlCommand.ExecuteNonQuery();
                    memoryStream.Dispose();

                    MessageBox.Show("Успешно");
                    ListMaterials list = new ListMaterials();
                    list.Show();
                    Hide();

                }
            }
            catch
            { 
                MessageBox.Show("Что-то пошло не так! Перепроверьте введённые данные"); 
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (maskedTextBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || richTextBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")  
            {
                MessageBox.Show("Вы ввели не все данные! Пожалуйста, перепроверьте");
            }
            else
            {
                InsertRecord();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            richTextBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListMaterials list = new ListMaterials();
            list.Show();
            Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры и символ ',' ");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }
    }

}
