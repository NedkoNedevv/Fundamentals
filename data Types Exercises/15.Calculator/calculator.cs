﻿using System;


namespace _15.Calculator
{
    class calculator
    {
        static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var action = Console.ReadLine();
            var secondNUmber = int.Parse(Console.ReadLine());
            var result = 0;

            switch (action)
            {
                case "-":
                    result = firstNumber - secondNUmber;
                    break;
                case "+":
                    result = firstNumber + secondNUmber;
                    break;
                case "/":
                    result = firstNumber / secondNUmber;
                    break;
                case "*":
                    result = firstNumber * secondNUmber;
                    break;
            }
            Console.WriteLine($"{firstNumber} {action} {secondNUmber} = {result}");
        }
    }
}
