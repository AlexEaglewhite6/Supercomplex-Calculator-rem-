using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supercomplex_Calculator__rem_
{
    internal class Calculator
    {
        public int intA;
        public int intB;
        public double doubleA;
        public double doubleB;
        public bool boolA;
        public bool boolB;
        private string type;
        private DivideByZeroException ex = new DivideByZeroException("Дорогой пользователь, Вы кринж!\nНе пытайтесь больше делить на ноль, пожалуйста!\nИначе за Вами поедет дурка!");
        private Exception factorialEx = new Exception("Дорогой пользователь, Вы кринж!\nФакториал числа n — это произведение всех натуральных чисел от 1 до n включительно!");
        public Calculator()
        {

        }
        public Calculator(int A, int B)
        {
            intA = A;
            intB = B;
            type = "int";
        }
        public Calculator(double A, double B)
        {
            doubleA = A;
            doubleB = B;
            type = "double";
        }
        public Calculator(bool A, bool B)
        {
            boolA = A;
            boolB = B;
            type = "bool";
        }
        private int factorial(int A)
        {
            int fac;
            fac = A;
            for (int i = A - 1; i >= 1; i--)
            {
                fac *= i;
            }
            return fac;
        }
        public string calculate(string op, string type)
        {
            switch (op)
            {
                case "+":
                    if(type == "int") { return (intA + intB).ToString();}
                    if (type == "double") { return (doubleA + doubleB).ToString(); }
                    break;
                case "-":
                    if (type == "int") { return (intA - intB).ToString(); }
                    if (type == "double") { return (doubleA - doubleB).ToString(); }
                    break;
                case "*":
                    if (type == "int") { return (intA * intB).ToString(); }
                    if (type == "double") { return (doubleA * doubleB).ToString(); }
                    break;
                case "/":
                    try
                    {
                        if (type == "int") { return (intA / intB).ToString(); }
                        if (type == "double") { return (doubleA / doubleB).ToString(); }
                    } catch
                    {
                        MessageBox.Show(this.ex.Message, "Ужас");
                    }
                    break;
                case "%":
                    try
                    {
                        if (type == "int") { return (intA % intB).ToString(); }
                        if (type == "double") 
                        {
                            if(doubleB != 0) { return (doubleA % doubleB).ToString();}
                            else { MessageBox.Show(ex.Message, "Ужас"); }
                        }
                    }
                    catch
                    {
                        MessageBox.Show(this.ex.Message, "Ужас");
                    }
                    break;
                case "√":
                    if (type == "int") { return Math.Sqrt(intA).ToString() + "\n" + Math.Sqrt(intB).ToString(); }
                    if (type == "double") { return Math.Sqrt(doubleA).ToString() + "\n" + Math.Sqrt(doubleB).ToString(); }
                    break;
                case "n²":
                    if (type == "int") { return (intA * intA).ToString() + "\n" + (intB * intB).ToString(); }
                    if (type == "double") { return (doubleA * doubleA).ToString() + "\n" + (doubleB * doubleB).ToString(); }
                    break;
                case "n^m":
                    if (type == "int") { return Math.Pow(intA, intB).ToString(); }
                    if (type == "double") { return Math.Pow(doubleA, doubleB).ToString(); }
                    break;
                case "n!":
                    if (type == "int") { return factorial(intA).ToString() + "\n" + factorial(intB).ToString(); }
                    if (type == "double") { MessageBox.Show(factorialEx.Message, "Ужас"); return null; }
                    break;
                default:
                    return "";
            }
            return "";
        }
    }
}
