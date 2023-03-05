using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace соне
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.listBox1.Items.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|textBox2.Text==""| textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show("Эээ, любезный, кабанчиком ввел строки как положено", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                        listBox1.Items.Clear();
                        int count = int.Parse(this.textBox1.Text);
                        double x1 = double.Parse(this.textBox2.Text);
                        double x2 = double.Parse(this.textBox3.Text);
                        double A = double.Parse(this.textBox4.Text);
                        var items = new object[count];
                        var dx = (x2 - x1) / (count - 1);
                        var rnd = new Random();
                        for (int i = 0; i < items.Length; i++)
                        {
                            double x = x1 + dx * i;
                            if (x < A)
                            {
                                items[i] = $"При значении x={x} функция имеет значение {A - Math.Sqrt(Math.Pow(A, 2) - Math.Pow(x - A, 2))}";
                            }
                            else
                            {
                                items[i] = $"При значении x={x} функция имеет значение {A * Math.Pow(x - A, 1.5)}";
                            }
                        }

                        this.listBox1.Items.AddRange(items);
                    }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
