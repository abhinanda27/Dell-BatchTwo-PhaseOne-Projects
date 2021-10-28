using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class TupleExample
    {

        //static Tuple<int, int>Calculate(IEnumerable<int>values)
        //{
        //    int count = 0;
        //    int sum = 0;

        //    foreach (var value in values)
        //    {
        //        count++;
        //        sum += value;
        //    }
        //    Tuple<int, int> result = Tuple.Create(count, sum);
        //    return result;
        //}

        //static (int count,int sum)Calculate(IEnumerable<int> values)
        //{
        //    int count = 0;
        //    int sum = 0;

        //    foreach (var value in values)
        //    {
        //        count++;
        //        sum += value;
        //    }
        //    Tuple<int, int> result = Tuple.Create(count, sum);
        //    return (count,sum);
        //}

        //static void Main(string[]args)
        //{
        //    var values = new List<int>() { 10, 20, 30, 40, 50 };
        //    var myResult = Calculate(values);
        //    Console.WriteLine($"There are{myResult.Item1}values");
        //    Console.WriteLine($"Sum of values:{myResult.Item2}");
        //    Console.ReadKey();
        //}
    }
}
