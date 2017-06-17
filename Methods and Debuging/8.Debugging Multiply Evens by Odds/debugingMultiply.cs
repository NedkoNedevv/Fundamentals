﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Debugging_Multiply_Evens_by_Odds
{
    class debugingMultiply
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
         .ToCharArray();

            GetMultiplayEvenByOdds(number);
        }
        static void GetMultiplayEvenByOdds(char[] number)
        {
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                var num = 0;
                int.TryParse(number[i].ToString(), out num);
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            var multiplay = evenSum * oddSum;
            Console.WriteLine(multiplay);
        }
    }
}
