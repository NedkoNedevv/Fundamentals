﻿using System;
using System.Collections.Generic;


namespace _13.Digits_with_Words
{
    class digitsWord
    {
        static void Main()
        {
            var number = Console.ReadLine();
            var digtsAsWords = new List<string>
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };
            

            for (int i = 0; i < digtsAsWords.Count; i++)
            {
                if (number == digtsAsWords[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
