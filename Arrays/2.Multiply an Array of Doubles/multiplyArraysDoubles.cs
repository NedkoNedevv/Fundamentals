﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiply_an_Array_of_Doubles
{
    class multiplyArraysDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
             .Split()
             .Select(double.Parse)
             .ToArray();
            double n = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= n;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
