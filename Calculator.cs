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

        public string calculate(string op, string type)
        {
            
            switch(op)
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
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"Дорогой пользователь, Вы кринж!\nОшибка: {ex.Message}", "Ужас");
                    }
                    break;
                default:
                    return "";
            }
            return "";
        }
    }
}
