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

namespace Box
{
    public partial class ListMaterials : Form
    {
        public static string Current;

        public ListMaterials()
        {
            InitializeComponent();
        }

        private void ListMaterials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "handicraftBoxDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.handicraftBoxDataSet.Material);

            pictureBox1.Image = Properties.Resources._6;


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.Material where Category = '" + comboBox3.Text + "'";
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
            string Mysql = @"Select * from  dbo.Material where TypeOfPackaging = '" + comboBox1.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.Material where ProductType = '" + comboBox2.Text + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.Material";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
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
            AboutUs us = new AboutUs();
            us.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительное хотите удалить материал = " + " " + Current, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string mySelectQuery = $"Delete from Material where Article = {Current}";//Удаление выбранной строки
                using (SqlConnection conn = new SqlConnection(Input.connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(mySelectQuery, conn);
                    command.ExecuteNonQuery();
                }

                DataTable table = new DataTable();
                string sql = "Select * from Material";//Вывод оставшихся данных
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, Input.connectionString))
                {
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditMaterials em = new EditMaterials();
            em.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
