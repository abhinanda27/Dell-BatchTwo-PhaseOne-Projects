using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{

    public delegate void myDelegate(int x, int y);

    public class Calculation
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("The sum of 2 numbers is " + (num1 + num2));
        }

        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("The difference of 2 numbers is " + (num1 - num2));
        }

        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("The product of 2 numbers is " + (num1 * num2));
        }

        public void Divide(int num1, int num2)
        {
            Console.WriteLine("The division of 2 numbers is " + (num1 / num2));
        }

    }
    class DelegateDemonstrations
    {
        //static void Main(string[] args)
        //{
        //    //SingleCastDelegate
        //    Calculation calc = new Calculation();
        //    myDelegate myDel1 = new myDelegate(calc.Add);
        //    myDel1(100, 20);
        //    myDel1 = new myDelegate(calc.Subtract);
        //    myDel1(100, 20);
        //    myDel1 += calc.Multiply;
        //    //myDel1 = new myDelegate(calc.Multiply);
        //    myDel1(100, 20);
        //    myDel1 = new myDelegate(calc.Divide);
        //    myDel1(100, 20);
        //    Console.ReadKey();


        //}
    }
}
