using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_s_Back
{
    class camelsBack
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToList();

            int camelBack = int.Parse(Console.ReadLine());

            int roundsCounter = 0;

            while (elements.Count > camelBack)
            {
                elements.RemoveAt(0);
                elements.RemoveAt(elements.Count - 1);
                roundsCounter++;
            }
            if (roundsCounter == 0)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", elements));
            }
            else
            {
                Console.WriteLine("{0} rounds", roundsCounter);
                Console.WriteLine("remaining: {0}", string.Join(" ", elements));
            }
        }
    }
}
