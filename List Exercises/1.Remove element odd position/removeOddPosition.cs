using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_element_odd_position
{
    class removeOddPosition
    {
        static void Main(string[] args)
        {
            var inputElements = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

            var oddPositions = new List<string>();

            for (int i = 0; i < inputElements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddPositions.Add(inputElements[i]);
                }
            }
            Console.WriteLine(string.Join("", oddPositions));
        }
    }
}
