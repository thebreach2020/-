using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//И снова привет, солнышко. Желаю удачно со всем разобраться :)
//Выше - все подключенные модули (нас пока интересуют только модули System (1) и System.Windows.Forms (2)).
//Точнее говоря, они называются пространствами имен.
namespace соне
{
    public partial class Form1 : Form//Создали компонент пространства имен (2). Назвали его Form1.
    {
        public Form1()
        {
            InitializeComponent();//Инициализировали этот компонент.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Тут нечаянно, это не надо (я дважды мискликнул).
            //На будущее. В случае с приложениями на WF, просто удалить функцию из файла, который ты сейчас смотришь, мало.
            //Там еще надо в другом файле чистить, не разобрался до конца. Так что код внутри функции меняй. Сами функции нет.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Clear();//Клик по button2 вызывает функцию Clear(), определенную в объекте Form1 класса. На этот объект мы ссылаемся
            //с помощью ключевого слова this. Аргументы функции (если мы их через двойные клики в конструкторе создаем) всегда
            //создаются автоматически, их не трогать!!!
        }

        private void Clear()//Вот эта функция Clear(), что мы вызываем через клик по кнопке. Она очищает данные всех текстбоксов (куда ты вводишь)
            //и листбокс (тут данные отображаются)
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
            }//Если хоть одна строка пуста (знак | означает логическое или)-выскакивает сообщение с ошибкой. Первая строка-то, что будет написано в 
            //этом сообщении. Вторая - название окна с ошибкой. Третий аргумент-отвечает за кнопку ОК, четвертый-за значок в кружке (слева от текста будет, увидишь).
            else {
                        listBox1.Items.Clear();//очищаем прежние значения листбокса. Даже если их не было)
                        int count = int.Parse(this.textBox1.Text);
                        double x1 = double.Parse(this.textBox2.Text);
                        double x2 = double.Parse(this.textBox3.Text);
                        double A = double.Parse(this.textBox4.Text);//Парсим строки, преобразовываем данные в них
                                                                    //(по умолчанию строки) в числа.
                        var items = new object[count];//создаем массив значений типа object длины count.
                        var dx = (x2 - x1) / (count - 1);//задаем шаг изменения значения икса
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
                            }//проходим циклом по массиву. Со второго прохода увеличиваем значение исходного икса
                            //на шаг его изменения, взятый (количество проходов-1) раз. Если икс меньше А
                            //то срабатывает блок if. Иначе срабатывает блок else.
                        }

                        this.listBox1.Items.AddRange(items);//Добавляем массив items в листбокс через встроенную функцию AddRange.
                //Очень Важное Пояснение. Данная функция работает с массивами данных только (ТОЛЬКО!!!!) типа object.
                //Именно поэтому мы создали массив типа object, а не int, double и т.д.
                    }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }//Создаем эту фишку следующим образом: в конструкторе (там, где элементы добавляешь), нажимаешь на текстбокс,
        //в окне свойства (я его тебе вроде открывал, оно справа снизу будет), нажимаешь на молнию желтую.
        //Там в блоке "ключ" ищешь KeyPress, жмешь дважды, и все автоматически создалось. Нужная функция откроется-и пиши в ней,
        //что тебе нужно.
        //А нужно следующее: запретить ввод букв в текстбокс. Допускаем символы цифр, бекспейс и запятую для ввода дробных чисел.
        //Для этого в блоке if задаем условия, разделенные знаком |: первое-проверка на цифру, второе-проверка на запятую, третье-проверка на бекспейс.
        //Если все правильно, то возвращаем "ничего" (на самом деле ввод допустимых значений в текстбокс). Иначе же просто ставим событие нажатие клавиши
        //как обработанное, но ничего не произойдет.
        //То же для всех четырех текстбоксов.
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
    //Вот и вся прога. Лайк поставить не забудь)
    //Идем дальше.
}
