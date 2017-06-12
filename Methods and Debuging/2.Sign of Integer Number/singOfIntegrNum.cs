using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sign_of_Integer_Number
{
    class singOfIntegrNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumbers(n);
        }

        static void PrintNumbers(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }

    }
}
