using System;

namespace DataStructureImplementation
{
    class Calculation
    {
        public  static void display(int[] numbers)
        {
           //////O(1) - COnstant Notation
           //// Console.WriteLine(numbers[0]);

           //// //O(1)+O(1)
           //// //O(2) - Constant Notation
           //// Console.WriteLine(numbers[0]);
           //// Console.WriteLine(numbers[0]);

           // //O(n) - Linear Notation

           // for (int i=0;i<numbers.Length;i++)
           //     {
           //     Console.WriteLine(numbers[i]);
           // }

           // //O(1)+O(n)+O(1)=>O(2)+O(n)
           // //O(n+2)=>O(n)- Linear notation
           // Console.WriteLine();
           // foreach (var number in numbers)
            
           //     Console.WriteLine(number);
           // Console.WriteLine();

           // //O(n)+O(n)
           // //O(n) --Linear notation
           // foreach (var number in numbers)
           //  Console.WriteLine(number);
           // foreach (var number in numbers)
           //     Console.WriteLine(number);

           // //O(n^2)- Quadratic notaion
           // foreach (var first in numbers)//O(n)
           //     foreach (var second in numbers)//O(n)
           //         Console.WriteLine(first +":"+second);

           // //O(n+n^2)=>O(n^3)
           // //O(n^2) - Quadratic notation
           // foreach(var number in numbers)//O(n)
           //     Console.WriteLine(number);
           // foreach (var first in numbers)//O(n)
           //     foreach (var second in numbers)//O(n)
           //         Console.WriteLine(first + ":" + second);

            //public static int fibonacci(int number)
            //{
            //    //O(2^n)- Exponential Notation
            //    if (number <= 1)
            //        return number;
            //    return fibonacci(number - 2) + fibonacci(number - 1);
            //}

        }

        public static void print(int[] numbers, string[]names)
        {
            //O(n)+O(m)
            //O(n+m)
    //        //O(n) - Linear Notation
    //        foreach(var number in numbers)//O(n)
    //            Console.WriteLine(number);
    //        foreach(var name in names)//O(m)
    //            Console.WriteLine(name);
    //    }

       
    //}
    //class BigONotationExample
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = { 10, 20, 30, 40, 50 };
    //        Calculation.display(numbers);
    //        string[] names = { "King", "Kochar", "Smit", "Sara" };
    //        Calculation.print(numbers, names);
    //        Console.ReadKey();
           
       }
    }
}
