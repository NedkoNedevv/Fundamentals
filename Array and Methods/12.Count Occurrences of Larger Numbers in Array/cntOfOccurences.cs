using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class cntOfOccurences
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
     .Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            var count = 0;

            foreach (var number in numbers)
            {
                if (p < number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
