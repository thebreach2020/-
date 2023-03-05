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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            if (e.KeyChar == (char)Keys.Return && delimitator1 < length - 1)
            {
                arr1.Add(double.Parse(textBox2.Text));
                textBox2.Clear();
                delimitator1++;
            }
            else
            {
                textBox2.Text = "Больше данные добавляться не будут";
                e.Handled = true;
            }
        }
        int length;
        private void button4_Click(object sender, EventArgs e)
        {
            length= int.Parse(textBox1.Text);
            
        }
        List<double> arr1=new List<double>();
        List<double> arr2 = new List<double>();
        int delimitator1 = 0;
        int delimitator2 = 0;
        
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            delimitator1 = 0;
            delimitator2 = 0;
            arr1.Clear();
            arr2.Clear();
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Return&&delimitator2<length-1)
            {
                arr2.Add(double.Parse(textBox3.Text));
                textBox3.Clear();
                delimitator2++;
            }
            else
            {
                textBox3.Text = "Больше данные добавляться не будут";
                e.Handled = true;
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            if (arr1.Min()<arr2.Min())
            {
                textBox4.Text = $"{arr1.Min()}";
            }
            else
            {
                textBox4.Text = $"{arr2.Min()}";
            }
            textBox5.Text = $"{arr1.Min()}";
            textBox6.Text = $"{arr2.Min()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
    }
}