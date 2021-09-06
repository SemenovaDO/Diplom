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
using System.IO;


namespace Box
{
    public partial class CurrenOrder : Form
    {
        public CurrenOrder()
        {
            InitializeComponent();
        }
        private void CurrenOrder_Load(object sender, EventArgs e)
        {
            string Mysql = @"Select * from  dbo.OrderList where  CustomerEmail = '" + Input.login + "' and Status != 'Выполнен' and Status != 'Возврат '";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(Mysql, Input.connectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Update();
            }

            dataGridView1.Columns[0].HeaderText = "Номер заказа";
            dataGridView1.Columns[1].HeaderText = "Дата заказа";
            dataGridView1.Columns[2].HeaderText = "Дата выполнения";
            dataGridView1.Columns[3].HeaderText = "Артикул";
            dataGridView1.Columns[4].HeaderText = "Количество";
            dataGridView1.Columns[5].HeaderText = "E-mail";
            dataGridView1.Columns[6].HeaderText = "Город";
            dataGridView1.Columns[7].HeaderText = "Адрес";
            dataGridView1.Columns[8].HeaderText = "Номер телефона";
            dataGridView1.Columns[9].HeaderText = "Сумма";
            dataGridView1.Columns[10].HeaderText = "Статус";
            dataGridView1.Columns[11].HeaderText = "Комментарий";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrder add = new AddOrder();
            add.Show();
            Hide();
        }
    }
}
