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
            pictureBox1.Image = Properties.Resources._6;
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
            try
            {
                if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Вы ввели не все данные!");
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        if (comboBox2.SelectedIndex == 0)
                        {
                            double chest = Convert.ToDouble(textBox1.Text);
                            double hips = Convert.ToDouble(textBox2.Text);
                            double goods = Convert.ToDouble(textBox3.Text);
                            double sleeve = Convert.ToDouble(textBox4.Text);
                            double bodice = Convert.ToDouble(textBox5.Text);
                            double a = bodice + 2 * goods + sleeve + 20;
                            label8.Text = a.ToString();

                        }
                        else if (comboBox2.SelectedIndex == 1)
                        {
                            double chest = Convert.ToDouble(textBox1.Text);
                            double hips = Convert.ToDouble(textBox2.Text);
                            double goods = Convert.ToDouble(textBox3.Text);
                            double sleeve = Convert.ToDouble(textBox4.Text);
                            double bodice = Convert.ToDouble(textBox5.Text);
                            double a = bodice + 4 * goods + sleeve;
                            label8.Text = a.ToString();
                        }
                        else if (comboBox2.SelectedIndex == 2)
                        {
                            double chest = Convert.ToDouble(textBox1.Text);
                            double hips = Convert.ToDouble(textBox2.Text);
                            double goods = Convert.ToDouble(textBox3.Text);
                            double sleeve = Convert.ToDouble(textBox4.Text);
                            double bodice = Convert.ToDouble(textBox5.Text);
                            double a = bodice + 2 * goods + sleeve + 20;
                            label8.Text = a.ToString();
                        }
                        else if (comboBox2.SelectedIndex == 3)
                        {
                            double chest = Convert.ToDouble(textBox1.Text);
                            double hips = Convert.ToDouble(textBox2.Text);
                            double goods = Convert.ToDouble(textBox3.Text);
                            double sleeve = Convert.ToDouble(textBox4.Text);
                            double bodice = Convert.ToDouble(textBox5.Text);
                            double a = bodice + 2 * goods + sleeve + 20;
                            label8.Text = a.ToString();
                        }
                        else if (comboBox2.SelectedIndex == 4)
                        {
                            double chest = Convert.ToDouble(textBox1.Text);
                            double hips = Convert.ToDouble(textBox2.Text);
                            double goods = Convert.ToDouble(textBox3.Text);
                            double sleeve = Convert.ToDouble(textBox4.Text);
                            double bodice = Convert.ToDouble(textBox5.Text);
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
                        double chest = Convert.ToDouble(textBox1.Text);
                        double hips = Convert.ToDouble(textBox2.Text);
                        double goods = Convert.ToDouble(textBox3.Text);
                        double sleeve = Convert.ToDouble(textBox4.Text);
                        double bodice = Convert.ToDouble(textBox5.Text);
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
                        double chest = Convert.ToDouble(textBox1.Text);
                        double hips = Convert.ToDouble(textBox2.Text);
                        double goods = Convert.ToDouble(textBox3.Text);
                        double sleeve = Convert.ToDouble(textBox4.Text);
                        double bodice = Convert.ToDouble(textBox5.Text);
                        if (hips <= 100)
                        {
                            double a = hips + goods + 20;
                            label8.Text = a.ToString();
                        }
                        else
                        {
                            double a = 2 * goods + hips;
                            label8.Text = a.ToString();
                        }
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        double hips = Convert.ToDouble(textBox2.Text);
                        double goods = Convert.ToDouble(textBox3.Text);
                        if (comboBox2.SelectedIndex == 0)
                        {
                            double a = 2 * goods + 2 * (hips / 3) + 10;
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
                        double chest = Convert.ToDouble(textBox1.Text);
                        double hips = Convert.ToDouble(textBox2.Text);
                        double goods = Convert.ToDouble(textBox3.Text);
                        double sleeve = Convert.ToDouble(textBox4.Text);
                        double bodice = Convert.ToDouble(textBox5.Text);
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
                    else if (comboBox1.SelectedIndex == 5)
                    {
                        double chest = Convert.ToDouble(textBox1.Text);
                        double hips = Convert.ToDouble(textBox2.Text);
                        double goods = Convert.ToDouble(textBox3.Text);
                        double sleeve = Convert.ToDouble(textBox4.Text);
                        double bodice = Convert.ToDouble(textBox5.Text);
                        if (chest <= 52)
                        {
                            double a = goods + sleeve + 40;
                            label8.Text = a.ToString();
                        }
                        else
                        {
                            double a = 2 * goods + sleeve + 40;
                            label8.Text = a.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали тип изделия");
                    }
                }
            }
           catch
            {
                MessageBox.Show("Что-то пошло не так. Повторите попытку чуть позже");
            }
  
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label15.Visible = true;
                comboBox2.Visible = true;

                label4.Visible = true;
                label11.Visible = true;
                textBox4.Visible = true;
                pictureBox5.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                textBox5.Visible = true;
                pictureBox6.Visible = true;

                label10.Visible = true;
                label17.Visible = true;
                textBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label15.Visible = false;
                comboBox2.Visible = false;

                label4.Visible = true;
                label11.Visible = true;
                textBox4.Visible = true;
                pictureBox5.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                textBox5.Visible = true;
                pictureBox6.Visible = true;

                label10.Visible = true;
                label17.Visible = true;
                textBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label4.Visible = false;
                label11.Visible = false;
                textBox4.Visible = false;
                pictureBox5.Visible = false;

                label13.Visible = false;
                label14.Visible = false;
                textBox5.Visible = false;
                pictureBox6.Visible = false;


                label10.Visible = false;
                label17.Visible = false;
                textBox1.Visible = false;
                pictureBox2.Visible = false;

                label15.Visible = false;
                comboBox2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label15.Visible = true;
                comboBox2.Visible = true;

                label4.Visible = false;
                label11.Visible = false;
                textBox4.Visible = false;
                pictureBox5.Visible = false;

                label13.Visible = false;
                label14.Visible = false;
                textBox5.Visible = false;
                pictureBox6.Visible = false;

                label10.Visible = false;
                label17.Visible = false;
                textBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label15.Visible = false;
                comboBox2.Visible = false;

                label4.Visible = true;
                label11.Visible = true;
                textBox4.Visible = true;
                pictureBox5.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                textBox5.Visible = true;
                pictureBox6.Visible = true;

                label10.Visible = true;
                label17.Visible = true;
                textBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label15.Visible = false;
                comboBox2.Visible = false;

                label4.Visible = true;
                label11.Visible = true;
                textBox4.Visible = true;
                pictureBox5.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                textBox5.Visible = true;
                pictureBox6.Visible = true;

                label10.Visible = true;
                label17.Visible = true;
                textBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("Вы не ввели тип изделия:");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только цифры");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }

        private void словарьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Glossary g = new Glossary();
            g.Show();
            Hide();
        }
    }
}
