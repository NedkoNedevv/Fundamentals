using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Largest_Element_in_Array
{
    class largestElements
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var arrayOfInt = new int[num];

            for (int cnt = 0; cnt < num; cnt++)
            {
                arrayOfInt[cnt] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(arrayOfInt.Max());
        }
    }
}
