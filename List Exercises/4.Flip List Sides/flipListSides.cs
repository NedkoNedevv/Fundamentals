using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Flip_List_Sides
{
    class flipListSides
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                 .Split(' ').ToList();

            string firstElement = list[0];
            string lastElement = list[list.Count - 1];

            list.Reverse();

            list[0] = firstElement;
            list[list.Count - 1] = lastElement;

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
