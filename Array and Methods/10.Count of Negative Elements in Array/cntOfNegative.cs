using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
    class cntOfNegative
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var arrayOfInt = new int[num];
            var result = 0;
            for (int cnt = 0; cnt < num; cnt++)
            {
                var n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
