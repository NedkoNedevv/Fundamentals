using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class removeNegative
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
         .Split(new char[] { ' ' },
         StringSplitOptions.RemoveEmptyEntries)
         .Select(int.Parse)
         .Where(x => x > 0)
         .Reverse()
         .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
