using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Smallest_Element_in_Array
{
    class smallestElement
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split();
            var array = new int[stringArray.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(stringArray[i]);

            var smallest = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
                if (array[i] < smallest)
                    smallest = array[i];
            Console.WriteLine(smallest);
        }
    }
}
