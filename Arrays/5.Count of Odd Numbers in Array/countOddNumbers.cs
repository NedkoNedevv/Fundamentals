using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Count_of_Odd_Numbers_in_Array
{
    class countOddNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int oddElementsCnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddElementsCnt++;
                }
            }
            Console.WriteLine(oddElementsCnt);
        }
    }
}
