using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
    class countOfCapital
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var single = text.Where(s => s.Length == 1).ToArray();

            var count = 0;

            foreach (var letter in single)
            {
                var chars = char.Parse(letter);
                if (chars >= 65 && chars <= 90)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
