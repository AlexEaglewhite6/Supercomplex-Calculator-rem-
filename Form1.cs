using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supercomplex_Calculator__rem_
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        string type;
        public Form1()
        {
            InitializeComponent();
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
            
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            OperationsPanel.Enabled = false;
        }

        //Проверяет поля ввода на числа или логические значения, если false вырубает кнопочки
        public void chekingAccuracy()
        {
            //Для простоты переваривания информации глазками
            string a = textBox1.Text;
            string b = textBox2.Text;

            //Если поля пустые, то кнопочки off
            if (a == "" || b == "")
            {
                OperationsPanel.Enabled = false;
            }
            //Извините, но я все еще не придумал как вынести OperationsPanel.Enabled = true;
            else
            {
                //Проверяет оба значения на int
                if (int.TryParse(a, out int intA) && int.TryParse(b, out int intB))
                {
                    OperationsPanel.Enabled = true;
                    calc = new Calculator(intA, intB);
                    type = "int";
                }
                //Проверяет оба значения на double
                else if (double.TryParse(a, out double doubleA) && double.TryParse(b, out double doubleB))
                {
                    OperationsPanel.Enabled = true;
                    calc = new Calculator(doubleA, doubleB);
                    type = "double";
                }
                //Проверяет если одно из значений не double(т.е int)
                else if (double.TryParse(a, out double da) && int.TryParse(b, out int ib)) //Если a - double, b - int
                {
                    OperationsPanel.Enabled = true;
                    type = "double";
                    calc = new Calculator(da, Convert.ToDouble(ib));
                }
                else if (int.TryParse(a, out int ia) && double.TryParse(b, out double db)) //Если a - int, b - double
                {
                    OperationsPanel.Enabled = true;
                    type = "double";
                    calc = new Calculator(Convert.ToDouble(ia), db);
                }
                //Проверяет оба значения на bool
                else if ((a == "0" || a == "1") && (b == "0" || b == "1"))
                {
                    OperationsPanel.Enabled = true;
                    calc = new Calculator(Convert.ToBoolean(a), Convert.ToBoolean(b));
                    type = "bool";
                }
                else //Если со всем все плохо и текст - кракозябра, то вырубаем панельку с кнопочками
                {
                    OperationsPanel.Enabled = false;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chekingAccuracy();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            chekingAccuracy();
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("+", type);
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("-", type);
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("*", type);
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("/", type);
        }
    }
}
