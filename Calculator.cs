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
        private int intA;
        private int intB;
        private double doubleA;
        private double doubleB;
        private bool boolA;
        private bool boolB;
        private string type;
        //Для удобства вынес эксепшены
        private DivideByZeroException divByZeroEx = new DivideByZeroException("Дорогой пользователь, Вы кринж!\nНе пытайтесь больше делить на ноль, пожалуйста!\nИначе за Вами поедет дурка!");
        private Exception factorialEx = new Exception("Дорогой пользователь, Вы кринж!\nФакториал числа n — это произведение всех натуральных чисел от 1 до n включительно!");
        //Пустой конструктор, потому что нужен для объявления как глобальная переменная
        public Calculator()
        {

        }
        //Конструктор для одного int
        public Calculator(int A)
        {
            intA = A;
            type = "int";
        }
        //Конструктор для одного double
        public Calculator(double A)
        {
            doubleA = A;
            type = "double";
        }
        //Конструктор для двух int
        public Calculator(int A, int B)
        {
            intA = A;
            intB = B;
            type = "int";
        }
        //Конструктор для двух double
        public Calculator(double A, double B)
        {
            doubleA = A;
            doubleB = B;
            type = "double";
        }
        //Конструктор для bool
        public Calculator(bool A, bool B)
        {
            boolA = A;
            boolB = B;
        }
        private int factorial(int A)
        {
            if(A == 0 || A == 1) 
            {
                return 1; 
            }
            else
            {
                int f = A;
                for (int i = A - 1; i >= 1; i--)
                {
                    f *= i;
                }
                return f;
            }
            
        }
        //Основной вычисляющий метод
        public string calculate(string op, string type)
        {
            //Через свич проверяется каждая операция
            switch (op)
            {
                //Сложение
                case "+":
                    if(type == "int") { return (intA + intB).ToString();}
                    if (type == "double") { return (doubleA + doubleB).ToString(); }
                    break;
                //Вычитание
                case "-":
                    if (type == "int") { return (intA - intB).ToString(); }
                    if (type == "double") { return (doubleA - doubleB).ToString(); }
                    break;
                //Умножение
                case "*":
                    if (type == "int") { return (intA * intB).ToString(); }
                    if (type == "double") { return (doubleA * doubleB).ToString(); }
                    break;
                //Деление
                case "/":
                    try
                    {
                        if (type == "int") { return (intA / intB).ToString(); }
                        if (type == "double") { return (doubleA / doubleB).ToString(); }
                    } catch
                    {
                        //Ошибка деления на ноль
                        MessageBox.Show(divByZeroEx.Message, "Ужас");
                    }
                    break;
                //Деление по модулю
                case "%":
                    try
                    {
                        if (type == "int") { return (intA % intB).ToString(); }
                        if (type == "double") 
                        {
                            if(doubleB != 0) { return (doubleA % doubleB).ToString();}
                            //При вещественных числах он в ответ пишет "не число", поэтому здесь тоже вывод об ошибке
                            else { MessageBox.Show(divByZeroEx.Message, "Ужас"); }
                        }
                    }
                    catch
                    {
                        //Ошибка деления на ноль
                        MessageBox.Show(divByZeroEx.Message, "Ужас");
                    }
                    break;
                //Извлечение квадратного корня
                case "√":
                    if (type == "int") { return Math.Sqrt(intA).ToString() + "\n" + Math.Sqrt(intB).ToString(); }
                    if (type == "double") { return Math.Sqrt(doubleA).ToString() + "\n" + Math.Sqrt(doubleB).ToString(); }
                    break;
                //Возведение в квадрат
                case "n²":
                    if (type == "int") { return (intA * intA).ToString() + "\n" + (intB * intB).ToString(); }
                    if (type == "double") { return (doubleA * doubleA).ToString() + "\n" + (doubleB * doubleB).ToString(); }
                    break;
                //Возведение в степень
                case "n^m":
                    if (type == "int") { return Math.Pow(intA, intB).ToString(); }
                    if (type == "double") { return Math.Pow(doubleA, doubleB).ToString(); }
                    break;
                //Факториал
                case "n!":
                    if (type == "int") { return factorial(intA).ToString() + "\n" + factorial(intB).ToString(); }
                    if (type == "double") { MessageBox.Show(factorialEx.Message, "Ужас"); return null; }
                    break;
                //Логическое умножение
                case "AND":
                    return (boolA & boolB).ToString();
                //Логическое сложение
                case "OR":
                    return (boolA | boolB).ToString();
                //Исключающие ИЛИ
                case "XOR":
                    return (boolA ^ boolB).ToString();
                default:
                    return "";
            }
            // Без этого ретурна IDE ругается
            return "";
        }
    }
}
