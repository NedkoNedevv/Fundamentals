using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distinct_List
{
    class distinctList
    {
        static void Main(string[] args)
        {
            int[] element = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            //List<int> distinctElement = new List<int>();

            //for (int i = 0; i < element.Length; i++)
            //{
            //    int currentElement = element[i];

            //    if (!distinctElement.Contains(currentElement))
            //    {
            //        distinctElement.Add(currentElement);
            //    }
            //}
           HashSet<int> dictinctElement = new HashSet<int>(element);
            Console.WriteLine(string.Join(" ", dictinctElement));
        }
    }
}
