using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DayFour_Projects
{
    //class PriceException : Exception
    //{
    //    public PriceException() : base("Invalid Price Entered.") { }

    //    public PriceException(string message) : base(message) { }
    //}
    //class Exception_Example_Three
    //{

    //    static void Main(string[] args)
    //    {
    //        float sellingPrice, costPrice;
    //        Console.Write("Enter Selling Price:");
    //        sellingPrice = int.Parse(Console.ReadLine());
    //        Console.Write("Enter Cost Price:");
    //        costPrice = int.Parse(Console.ReadLine());
    //        try
    //        {
    //            if (sellingPrice >= 0)
    //            {
    //                if (costPrice >= 0)
    //                {
    //                    if (sellingPrice > costPrice)
    //                    {
    //                        Console.WriteLine("Profit Occured");

    //                    }
    //                    else if (costPrice > sellingPrice)
    //                    {
    //                        Console.WriteLine("Loss Occured");
    //                    }

    //                    else
    //                    {
    //                        Console.WriteLine("No Profit No Loss");
    //                    }
    //                }

    //                else
    //                {
    //                    throw new PriceException();
    //                }
    //            }
    //            else
    //            {
    //                throw new PriceException();
    //            }

    //        }
    //        catch (FormatException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        catch (PriceException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }

    //    }
    //}
}
