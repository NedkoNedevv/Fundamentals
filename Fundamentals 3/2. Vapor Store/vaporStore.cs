using System;
using System.Collections.Generic;

namespace _2.Vapor_Store
{
    class vaporStore
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());

            Dictionary<string, double> data = new Dictionary<string, double>();
            data["OutFall 4"] = 39.99;
            data["CS: OG"] = 15.99;
            data["Zplinter Zell"] = 19.99;
            data["Honored 2"] = 59.99;
            data["RoverWatch"] = 29.99;
            data["RoverWatch Origins Edition"] = 39.99;

            double startingBalance = balance;
            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                if (!data.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    double currentPrice = data[input];
                    if (currentPrice <= balance)
                    {
                        Console.WriteLine("Bought {0}", input);
                        balance -= currentPrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                if (Math.Abs(balance) < 0.00001)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}",
                 startingBalance - balance, balance);
        }
    }
}
