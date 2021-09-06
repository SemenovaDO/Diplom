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
    public partial class Glossary : Form
    {
        public static string Current;

        public Glossary()
        {
            InitializeComponent();
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
            AboutUs au = new AboutUs();
            au.Show();
            Hide();
        }

        private void Glossary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "handicraftBoxDataSet.Glossary". При необходимости она может быть перемещена или удалена.
            this.glossaryTableAdapter.Fill(this.handicraftBoxDataSet.Glossary);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14);

            pictureBox1.Image = Properties.Resources._6;

            if (Input.role == "Редактор")
            {
                button2.Visible = true;
                button1.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.Glossary where Word like '" + textBox1.Text + "%'";
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
            Current = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Вы действительное хотите удалить термин = " + " " + Current, "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string mySelectQuery = $"Delete from Glossary where ID = {Current}";//Удаление выбранной строки
                using (SqlConnection conn = new SqlConnection(Input.connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(mySelectQuery, conn);
                    command.ExecuteNonQuery();
                }
                DataTable table = new DataTable();
                string sql = "Select * from Glossary";//Вывод оставшихся данных
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, Input.connectionString))
                {
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGlossary add = new AddGlossary();
            add.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.Glossary";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }
        }
    }
}
