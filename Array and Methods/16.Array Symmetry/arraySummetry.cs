using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class arraySummetry
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
           .Split(new char[] { ' ' },
           StringSplitOptions.RemoveEmptyEntries)
           .ToArray();

            var len = text.Length / 2;
            var answer = "Yes";

            for (int i = 0; i < len; i++)
            {
                var first = text[i];
                var second = text[text.Length - 1 - i];

                if (first != second)
                {
                    answer = "No";
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
