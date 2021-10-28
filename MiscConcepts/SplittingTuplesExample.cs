﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscConcepts
{
    class SplittingTuplesExample
    {

        static(string, string,double) getCustomerDetails()
        {
            string customerName = "KingKochhar";
            string customerCode = "C001";
            double customerAmount = 20000;
            return (customerCode, customerName, customerAmount);
        }
        //static void Main(string[]args)
        //    //WayOne:
        //{
        //    //var custDetails = getCustomerDetails();
        //    //var code = custDetails.Item1;
        //    //var name = custDetails.Item2;
        //    //var amount = custDetails.Item3;

        //    //Way Two
        //    //(string code, string name, double amount) = getCustomerDetails();
        //    //Console.WriteLine($"{code}:{name}:{amount}");

        //    //Way Three
        //    var (code, name, amount) = getCustomerDetails();
        //    Console.WriteLine($"{code}:{name}:{amount}");
        //    Console.ReadKey();
        //}
    }
}
