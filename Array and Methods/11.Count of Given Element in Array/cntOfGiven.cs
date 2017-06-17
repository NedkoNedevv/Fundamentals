﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
    class cntOfGiven
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

            var num = int.Parse(Console.ReadLine());
            var count = 0;
            foreach (var number in numbers)
            {
                if (number == num)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
