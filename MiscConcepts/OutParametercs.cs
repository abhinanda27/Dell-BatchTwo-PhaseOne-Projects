using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class OutParametercs
    {
        static void GetCustomerDetails(out string CustomerName, out int CustomerAge, out double CustomerAmount)

        {
            CustomerName = "KingKocchar";
            CustomerAge = 45;
            CustomerAmount = 120000;
        }
        static void Main(string[]args)
        {
            //Declarations
            //string CustomerName;
            //int CustomerAge;
            //double CustomerAmount;

            //Method Calling to get data from DB
            GetCustomerDetails(out string CustomerName, out int CustomerAge, out _);//if not required later can declare here itself

            //Console.WriteLine($"{CustomerName}:{CustomerAge}:{CustomerAmount}");
            Console.WriteLine($"{CustomerName}:{CustomerAge}");
            Console.ReadKey();
        }
    }
}
