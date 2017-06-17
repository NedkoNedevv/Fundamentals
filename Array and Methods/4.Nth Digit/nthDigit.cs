using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nth_Digit
{
    class nthDigit
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
           int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(num, index));
        }
        static long FindNthDigit(long num, int index)
        {
            int currentIndex = 1;
            while (num != 0)
            {
                if (currentIndex == index)
                {
                    return num % 10;
                }
                currentIndex++;
                num /= 10;
            }
            return num % 10;
        }

    }
}
