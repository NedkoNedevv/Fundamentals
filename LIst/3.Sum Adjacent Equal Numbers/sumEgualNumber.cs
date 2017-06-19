using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class sumEgualNumber
    {
        static void Main(string[] args)
        {
          
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();
            numbers.Add(int.MaxValue);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    var sum = numbers[i] + numbers[i + 1];
                    numbers[i + 1] = sum;
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
            numbers.RemoveAt(numbers.Count - 1);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
