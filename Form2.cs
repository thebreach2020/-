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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
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
            this.listBox2.Items.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int count = int.Parse(this.textBox1.Text);
            double x1 = double.Parse(this.textBox2.Text);
            double x2 = double.Parse(this.textBox3.Text);
            double h = double.Parse(this.textBox4.Text);
            var items1 = new object[count];
            var items2 = new object[count];
            var dx = double.Parse(this.textBox4.Text);
            var eps = double.Parse(this.textBox5.Text);
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
