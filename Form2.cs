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
            //Это лишнее.
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
        }//Пока все похоже на то, что было в первой расчетке.
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | textBox5.Text == "")
            {
                MessageBox.Show("Эээ, любезный, кабанчиком ввел строки как положено", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }//То же, что и в первой. Обработка пустых строк, сообщение об ошибке. См. ргр1.
            else if (double.Parse(this.textBox2.Text) >= 1 | double.Parse(this.textBox3.Text) >= 1 | double.Parse(this.textBox4.Text) >= 1 | double.Parse(this.textBox5.Text) >= 1)
            {
                MessageBox.Show("Введите числа, меньшие единицы", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                int count = int.Parse(this.textBox1.Text);//Хуй знает, нахуя это делать, если у нас и так есть шаг изменения
                                                          //Икса. Но раз просят, то добавим.
                double x1 = double.Parse(this.textBox2.Text);//Нижняя граница.
                double x2 = double.Parse(this.textBox3.Text);//Верхняя граница.
                List<double> items1 = new List<double>();
                List<double> items2 = new List<double>();
                var dx = double.Parse(this.textBox4.Text);//Задали шаг.
                var eps = double.Parse(this.textBox5.Text);//Задали точность.
                for (double i = x1; i <= x2; i += dx)
                {
                    items1.Add(Math.Round(i, 2));
                    items1.Add(Math.Log(Math.Pow(1 + i, i + 0.5) / Math.Sqrt(1 - i)) - Math.Pow(i, 2) - i);
                }

                for (double i = x1; i <= x2; i += dx)
                {
                    items2.Add(Math.Round(i, 2));
                    for (double number = 3, summa11 = 0; ; number += 2)
                    {

                        double k = Math.Pow(i, number) * ((((number - 1) * i) - 1) / (number * (number - 1)));
                        summa11 += k;

                        if (Math.Abs(k) < eps)
                        {
                            items2.Add(summa11);
                            break;
                        }

                    }

                }
                //Из первой расчетки здесь создание исходных данных (только тут вместо массивов списки,т.к.
                //нам в него нужно добавлять элементы. В массив мы добавить элементы не можем).
                //Кроме того, длину списка можно инициализировать динамически. Длину массива-нет.
                //А вот пляски, начинающиеся с первого цикла-тут смотри лабу11 из файла с лабами (где их 30 штук.)
                //Первый цикл-расчет по формуле, второй-расчет по ряду.
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
                //Создали два массива object'ов, добавили в них значения из списков.
                //Затем AddRange эти массивы в листбоксы.
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            //Это лишнее.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //И это лишнее.
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
       //Запрет ввода букв во всех текстбоксах, как в ргр 1. Все точь-в-точь.
    }
    //Ну вот и все на сегодня. Береги себя и своих близких. До свидания.
    //Там еще 3 форма откроется, если запустишь проект, ее пока не трогай, я ее не доделал.
    //Как доделаю, скину обязательно.
}
