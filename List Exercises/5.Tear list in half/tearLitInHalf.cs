using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListHalf
{
    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(' ').Select(int.Parse)
               .ToList();

            var leftHalf = numbers
                .Take(numbers.Count / 2)
                .ToList();

            var rightHalf = numbers
                .Skip(numbers.Count / 2)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < rightHalf.Count; i++)
            {
                var leftNum = leftHalf[i];
                var rightNum = rightHalf[i];

                var first = rightNum / 10;
                var second = rightNum % 10;

                result.Add(first);
                result.Add(leftNum);
                result.Add(second);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}