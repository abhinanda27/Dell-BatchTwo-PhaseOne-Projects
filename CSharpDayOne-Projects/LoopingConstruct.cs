using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDayOne_Projects
{
    class LoopingConstruct
    {
        static void Main(string[] args)
        {
            //For Loop
            //- when u want to start from a number and end at fixed length when number of iterations are known

            //for (int i=0; i<=10;i++)
            //{
            //    if (i % 2 == 0)

            //        Console.WriteLine(i);
            //    else
            //        continue;

            //}

            //while loop - when repetitions are not known

            //   bool needMoreCandies = true;
            //   int candiesCount = 0;
            //   while(needMoreCandies)
            //   {
            //       Console.WriteLine("Do you need one more candy?");
            //       string answer = Console.ReadLine();
            //       if (answer == "yes" || answer == "Yes" || answer == "YES")
            //           candiesCount++;
            //       else
            //           needMoreCandies = false;
            //}
            //   Console.WriteLine("Candies count :" + candiesCount);

            //do While Loop - loop works atleast once without chking the conditions

            //int candiesCount = 0;
            //string answer;
            //do
            //{
            //    candiesCount++;
            //    Console.WriteLine("Do you need one more candy?");
            //   answer = Console.ReadLine();

            //}
            //while (answer == "yes" || answer == "Yes" || answer == "YES");
            //Console.WriteLine("Candies count :" + candiesCount);

            //Console.ReadLine();

            string choice;
            do
            {
                Console.WriteLine("Enter your question?");
                var question = Console.ReadLine();
                switch (question)
                {
                    case "Do you love C#?":
                        Console.WriteLine("Yes, I am in love with programming lang");
                        break;
                    case "How do I look today?":
                    case "Would you like to praise about me":
                        Console.WriteLine("Look awesome!!");
                        break;

                    default:
                        Console.WriteLine("I have no clue what you are talking about");
                        break;
                }
                Console.Write("Do you wish to continue?(yes/no):");
                choice = Console.ReadLine();
            }
            while (choice.ToUpper() == "YES");
            Console.ReadLine();
        }
    }
}
