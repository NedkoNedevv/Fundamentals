using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = raiseToPower(number, power);
            Console.WriteLine(result);
        }
        private static double raiseToPower(double number, int power)
        {
            double result = number;
            for (int num = 1; num < power; num++)
            {
                result *= number;
            }
            return result;
        }
    }
}
