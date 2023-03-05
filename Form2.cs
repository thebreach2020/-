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
        double Factorial(double n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int count = int.Parse(this.textBox1.Text);
            double x1 = double.Parse(this.textBox2.Text);
            double x2 = double.Parse(this.textBox3.Text);
            List<double> items1 = new List<double>();
            List<double> items2 = new List<double>();
            var dx = double.Parse(this.textBox4.Text);
            var eps = double.Parse(this.textBox5.Text);
            for (double i = x1; i <= x2; i += dx)
            {
                items1.Add(Math.Round(i, 2));
                items1.Add(Math.Log(Math.Pow(1+i,i+0.5)/Math.Sqrt(1-i))-Math.Pow(i,2)-i);
            }

            for (double i = x1; i <= x2; i += dx)
            {
                items2.Add(Math.Round(i, 2));
                for (double number = 3,  summa11 = 0; ; number+=2)
                {
                    
                    double k = Math.Pow(i,number)*((((number-1)*i)-1)/(number*(number-1)));
                    summa11 += k;
                    
                    if (Math.Abs(k) < eps)
                    {
                        items2.Add(summa11);
                        break;
                    }
                    
                }
                 
            }
            var items2obj = new object[items2.Count];
            for (int i = 0; i < items2.Count; i++)
            {
                items2obj[i] = items2[i];
            }
            var items1obj = new object[items1.Count];
            for (int i = 0; i < items1.Count; i++)
            {
                items1obj[i] = items1[i];
            }
            this.listBox1.Items.AddRange(items1obj);
            this.listBox2.Items.AddRange(items2obj);
            }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
