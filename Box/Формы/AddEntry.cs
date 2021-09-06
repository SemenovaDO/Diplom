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
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
        }
        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name; 
                string category = comboBox1.Text;


                string query = "INSERT INTO Entry (Data, Category, Extension, FileName) VALUES(@data, @category,  @extn, @name)";
                using (SqlConnection cb = GetConnectioin())
                {
                    SqlCommand cmd = new SqlCommand(query, cb);
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cb.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private SqlConnection GetConnectioin()
        {
            return new SqlConnection(Input.connectionString);
        }
        private void LoadData()
        {
            using (SqlConnection cb = GetConnectioin())
            {
                string query = "SELECT ID, FileName, Category, Extension FROM Entry";
                SqlDataAdapter abp = new SqlDataAdapter(query, cb);
                DataTable dt = new DataTable();
                abp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void OpenFile(int id)
        {
            using (SqlConnection cb = GetConnectioin())
            {
                string query = "SELECT Data, Category, FileName, Extension FROM Entry WHERE ID = @id";
                SqlCommand abp = new SqlCommand(query, cb);
                abp.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cb.Open();
                var reader = abp.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var category = reader["Category"];
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileNAme = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileNAme, data);
                    System.Diagnostics.Process.Start(newFileNAme);
                }
            }
        }
        private void AddEntry_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Input.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Category FROM CategoryRecommendation";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dls = new OpenFileDialog();
            dls.ShowDialog();
            textBox1.Text = dls.FileName;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""|| comboBox1.Text == "")
            {
                MessageBox.Show("Сначала добавьте файл и выберите категорию статьи!");
            }
            else
            {
                try
                {
                    SaveFile(textBox1.Text);
                    MessageBox.Show("Сохранено");
                    ListEntry list = new ListEntry();
                    list.Show();
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так! Повторите попытку позже.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListEntry list = new ListEntry();
            list.Show();
            Hide();
        }
    }
}
