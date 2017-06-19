using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class appendLists
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentIndex = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                currentIndex.Reverse();

                foreach (var num in currentIndex)
                {
                    result.Add(num);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
