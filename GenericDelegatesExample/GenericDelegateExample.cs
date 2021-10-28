using System;

namespace GenericDelegatesExample
{
    //class GenericDelegateExample
    //{

    //    public delegate double AdditionOneDelegate(int num1, float num2, double num3);
    //    public delegate void AdditionTwoDelegate(int num1, float num2, double num3);
    //    public delegate bool CheckLength(string checklength);
    //    class calculation
    //    {
    //        public static double AdditionOne(int num1, float num2, double num3)
    //        {
    //            return num1 + num2 + num3;
    //        }

    //        public static void AdditionTwo(int num1, float num2, double num3)
    //        {
    //            Console.WriteLine("Result:" + (num1 + num2 + num3));
    //        }


    //        public static bool CheckLength(string name)

    //        {
    //            if (name.Length > 5)
    //                return true;
    //            return false;
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        //AdditionOneDelegate objOne = new AdditionOneDelegate(calculation.AdditionOne);
    //        //double result = objOne.Invoke(50, 225.65F, 125.567);
    //        //Console.WriteLine("Addition One Result" +result);

    //        Func<int, float, double, double> objOne = new Func<int, float, double, double>(calculation.AdditionOne);

    //        //AdditionTwoDelegate objTwo = new AdditionTwoDelegate(calculation.AdditionTwo);
    //        //objTwo.Invoke(50, 225.65F, 567);

    //        Action<int, float, double> objTwo = new Action<int, float, double>(calculation.AdditionTwo);
    //        objTwo.Invoke(50, 225.65F, 125.567);


    //        //CheckLength objThree = new CheckLength(calculation.CheckLength);
    //        //bool status = objThree.Invoke("Bhawna");
    //        //Console.WriteLine("Check Length Status:" +status);

    //        Predicate<string> objThree = new Predicate<string>(calculation.CheckLength);
    //        bool status = objThree.Invoke("Bhawna");
    //        Console.WriteLine("Check Length Status: " + status);

    //        Console.ReadKey();
    //    }
    //}
}
