using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            Hide();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.Show();
            Hide();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.kisspng_registered_trademark_symbol_clip_art_info_icon_5b5e436b0cba43_4658204515329042990521;
            pictureBox3.Image = Properties.Resources.kisspng_registered_trademark_symbol_clip_art_info_icon_5b5e436b0cba43_4658204515329042990521;
            pictureBox4.Image = Properties.Resources.kisspng_registered_trademark_symbol_clip_art_info_icon_5b5e436b0cba43_4658204515329042990521;
            pictureBox5.Image = Properties.Resources.kisspng_registered_trademark_symbol_clip_art_info_icon_5b5e436b0cba43_4658204515329042990521;
            pictureBox6.Image = Properties.Resources.kisspng_registered_trademark_symbol_clip_art_info_icon_5b5e436b0cba43_4658204515329042990521;
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double chest = double.Parse(textBox1.Text);
            double hips = double.Parse(textBox2.Text);
            double goods = double.Parse(textBox3.Text);
            double sleeve = double.Parse(textBox4.Text);
            double bodice = double.Parse(textBox5.Text);


            if (textBox1.Text != null & textBox2.Text != null & textBox3.Text != null & textBox4.Text != null & textBox5.Text != null)
            {
              
                if (comboBox1.SelectedIndex == 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        double a = bodice + 2 * goods + sleeve + 20;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        double a = bodice + 4 * goods + sleeve;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        double a = bodice + 2 * goods + sleeve + 20;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        double a = bodice + 2 * goods + sleeve + 20;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        double a = bodice + goods + sleeve + 20;
                        label8.Text = a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали тип юбки");
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (chest <= 56)
                    {
                        double a = goods + sleeve + 15;
                        label8.Text = a.ToString();
                    }
                    else
                    {
                        double a = 2 * goods + sleeve;
                        label8.Text = a.ToString();
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (hips <= 100)
                    {
                        double a = goods + 20;
                        label8.Text = a.ToString();
                    }
                    else
                    {
                        double a = 2 * goods;
                        label8.Text = a.ToString();
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        double a = 2 * goods + 2 * (hips / 3.14) + 10;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        double a = 4 * goods;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        double a = 2 * goods + 20;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        double a = 3 * goods;
                        label8.Text = a.ToString();
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        double a = goods + 30;
                        label8.Text = a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали тип юбки");
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    if (chest <= 52)
                    {
                        double a = 2 * goods + 20;
                        label8.Text = a.ToString();
                    }
                    else
                    {
                        double a = 2 * goods + sleeve + 20;
                        label8.Text = a.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали тип изделия");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label13.Visible = true;
                label14.Visible = true;
                textBox5.Visible = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }
    }
}
