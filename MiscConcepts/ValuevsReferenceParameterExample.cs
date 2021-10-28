using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    //class ValuevsReferenceParameterExample
    //{
    //    static (int,int)SwapByValue(int num1, int num2)
    //    {
    //        int temp = num1;
    //        num1 = num2;
    //        num2 = temp;
    //        return(num1, num2);
    //    }

    //    static void SwapByReference(ref int num1, ref int num2)
    //    {
    //        int temp = num1;
    //        num1 = num2;
    //        num2 = temp;
           
    //    }
    //    static void PassByValue(int num)
    //    {
    //        num = 100;
    //    }

    //    static void PassByReference(ref int num)
    //    {
    //        num = 100;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int num = 10;
    //        PassByValue(num);
    //        Console.WriteLine("Num : " + num);
    //        Console.WriteLine("****************");
    //        PassByReference(ref num);
    //        Console.WriteLine("Num: " + num);

    //        //Console.WriteLine(SwapByValue(100, 200));
           
    //        var(num1,num2)=SwapByValue(100,200);
    //        Console.WriteLine($"FirstNumber{num1}, Secondnumber {num2}", num1,num2);
    //        int number1 = 100, number2 = 200;
    //        SwapByReference(ref number1, ref number2);
    //        Console.WriteLine($"FirstNumber{number1},Secondnumber{number2}", number1, number2);

    //        Console.ReadKey();
    //    }
    //}
}
