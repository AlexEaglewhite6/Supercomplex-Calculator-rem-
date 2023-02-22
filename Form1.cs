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
            if (a == "" && b == "")
            {
                OperationsPanel.Enabled = false;
            } 
            //Если хотя бы одно поле не пустое
            else if ((a != "" && b == "") || (a == "" && b != "")) 
            {
                //Включается общая панелька, чтобы смогла работать вторая
                OperationsPanel.Enabled = true;
                TwoValuePanel.Enabled = false;

                string c;
                if (a != "") { c = a; }
                else { c = b; }

                if(int.TryParse(c, out int intC))
                {
                    calc = new Calculator(intC);
                    type = "int";
                } 
                else if (double.TryParse(c, out double doubleC))
                {
                    calc = new Calculator(doubleC);
                    type = "double";
                }
                else
                {
                    OperationsPanel.Enabled = false;
                }
            }
            //Если оба поля непустые
            else if (a != "" && b != "")
            {
                LogicalPanel.Enabled = false;
                OperationsPanel.Enabled = true;
                //Проверяет оба значения на int
                if (int.TryParse(a, out int intA) && int.TryParse(b, out int intB))
                {
                   if((intA == 1 || intA == 0) && (intB == 1 || intB == 0))
                    {
                        LogicalPanel.Enabled = true;
                    }
                    TwoValuePanel.Enabled = true;
                    calc = new Calculator(intA, intB);
                    type = "int";
                }
                //Проверяет оба значения на double
                else if (double.TryParse(a, out double doubleA) && double.TryParse(b, out double doubleB))
                {
                    LogicalPanel.Enabled = false;
                    calc = new Calculator(doubleA, doubleB);
                    type = "double";
                }
                //Проверяет если одно из значений не double(т.е int)
                //Если a - double, b - int
                else if (double.TryParse(a, out double da) && int.TryParse(b, out int ib)) 
                {
                    type = "double";
                    calc = new Calculator(da, Convert.ToDouble(ib));
                }
                //Если a - int, b - double
                else if (int.TryParse(a, out int ia) && double.TryParse(b, out double db)) 
                {
                    type = "double";
                    calc = new Calculator(Convert.ToDouble(ia), db);
                }
                //Если со всем все плохо и текст - кракозябра, то вырубаем панельку с кнопочками
                else
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

        private void DivisionByModuleBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("%", type);
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("√", type);
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("n²", type);
        }

        private void ExponentiationBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("n^m", type);
        }

        private void FactorialBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calc.calculate("n!", type);
        }
        //Здесь я не придумал ничего гениальнее чем просто запихнуть конструктор сюда и использовать его в трех кнопках
        //Я бы мог сюда запихать chekingAccuracy();, но оно так не будет работать, поэтому тоже дублируется
        private void CalcConstr()
        {
            
            bool boolA = Convert.ToBoolean(Convert.ToInt32(textBox1.Text));
            bool boolB = Convert.ToBoolean(Convert.ToInt32(textBox2.Text));
            calc = new Calculator(boolA, boolB);
            
        }
        private void AndBtn_Click(object sender, EventArgs e) 
        {
            CalcConstr();
            richTextBox1.Text = calc.calculate("AND", "bool");
            chekingAccuracy();
        }

        private void OrBtn_Click(object sender, EventArgs e)
        {
            CalcConstr();
            richTextBox1.Text = calc.calculate("OR", "bool");
            chekingAccuracy();
        }

        private void XorBtn_Click(object sender, EventArgs e)
        {
            CalcConstr();
            richTextBox1.Text = calc.calculate("XOR", "bool");
            chekingAccuracy();
        }
    }
}
