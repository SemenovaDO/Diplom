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
    public partial class ListMasterClass : Form
    {
        public static string Current;

        public ListMasterClass()
        {
            InitializeComponent();
        }

        private void ListMasterClass_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "handicraftBoxDataSet1.MasterClass". При необходимости она может быть перемещена или удалена.
            this.masterClassTableAdapter.Fill(this.handicraftBoxDataSet1.MasterClass);

            pictureBox1.Image = Properties.Resources._6;

            if (Input.role == "Редактор")
            {
                button2.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMasters_class add = new AddMasters_class();
            add.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительное хотите удалить мастер-класс = " + " " + Current, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string mySelectQuery = $"Delete from MasterClass where ID = {Current}";//Удаление выбранной строки
                using (SqlConnection conn = new SqlConnection(Input.connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(mySelectQuery, conn);
                    command.ExecuteNonQuery();
                }
                DataTable table = new DataTable();
                string sql = "Select * from MasterClass";//Вывод оставшихся данных
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, Input.connectionString))
                {
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var SelectedRow = dataGridView1.SelectedRows;
            foreach (var row in SelectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }
        private void OpenFile(int id)
        {
            using (SqlConnection cb = GetConnectioin())
            {
                string query = "SELECT Data, Extension, FileName FROM MasterClass WHERE ID = @id";
                SqlCommand abp = new SqlCommand(query, cb);
                abp.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cb.Open();
                var reader = abp.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileNAme = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileNAme, data);
                    System.Diagnostics.Process.Start(newFileNAme);
                }
            }
        }
        private SqlConnection GetConnectioin()
        {
            return new SqlConnection(Input.connectionString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuEditor menu = new MenuEditor();
            menu.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.MasterClass where FileName like '" + textBox1.Text + "%'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.MasterClass where Category = '" + comboBox1.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.MasterClass";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Show();
            Hide();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
            Hide();

        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }
    }
}
