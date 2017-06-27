using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Egual_sum_after_extraction
{
    class egualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine().Split(' ')
                   .Select(int.Parse).ToList();

            var secondNumbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            for (int first = 0; first < firstNumbers.Count; first++)
            {
                var number = firstNumbers[first];

                for (int second = 0; second < secondNumbers.Count; second++)
                {
                    if (number == secondNumbers[second])
                    {
                        secondNumbers.RemoveAt(second);
                        second--;
                    }
                }
            }
            var firstSum = firstNumbers.Sum();
            var secondSum = secondNumbers.Sum();

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
