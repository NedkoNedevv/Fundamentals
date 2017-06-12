using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Array_Elements
{
    class SumArrayElements
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] array = new int[numbers];

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                array[cnt] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                sum += array[cnt];
            }
            Console.WriteLine(sum);
        }
    }
}
