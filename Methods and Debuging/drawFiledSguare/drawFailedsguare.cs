using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawFiledSguare
{
    class drawFailedsguare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }

        }
    }
}
