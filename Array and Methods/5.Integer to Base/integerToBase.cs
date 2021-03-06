﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Integer_to_Base
{
    class integerToBase
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(num, toBase));
        }
        static string IntegerToBase(long number, int toBase)
        {
            string result = String.Empty;
            while (number > 0)
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;

        } 
    }
}
