using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rotate_Array_of_Strings
{
    class rotateArrays
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] resultArr = new string[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                resultArr[i + 1] = arr[i];
            }
            resultArr[0] = arr[arr.Length - 1];
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
