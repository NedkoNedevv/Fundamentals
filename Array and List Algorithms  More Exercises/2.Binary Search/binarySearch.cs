using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Binary_Search
{
    class binarySearch
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            int numberFind = int.Parse(Console.ReadLine());
            int countLinearSearch = LinearSearch(numbers, numberFind);
            int binarySearchCount = BinarySearch(numbers, numberFind);
            numbers.Sort();
            if (numbers.Contains(numberFind))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            Console.WriteLine($"Linear search made {countLinearSearch} iterations");
            Console.WriteLine($"Binary search made {binarySearchCount} iterations");
        }

        private static int BinarySearch(List<int> numbers, int numberFind)
        {
            numbers.Sort();
            int min = 0;
            int max = numbers.Count - 1;
            int count = 0;
            while (min <= max)
            {
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numberFind)
                {
                    min = midPoint + 1;
                }
                if (numbers[midPoint] > numberFind)
                {
                    max = midPoint - 1;
                }
                if (numbers[midPoint] == numberFind)
                {
                    break;
                }
            }
            return count;
        }

        private static int LinearSearch(List<int> numbers, int numberFind)
        {
            int count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                count++;
                if (numbers[i] == numberFind)
                {
                    return count;
                }
            }

            return count;
        }
    }
}
