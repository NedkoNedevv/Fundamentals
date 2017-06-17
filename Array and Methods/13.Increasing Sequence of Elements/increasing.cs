using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
    class increasing
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();

            string sequence = String.Empty;

            for (int cnt = 0; cnt < numbers.Length - 1; cnt++)
            {
                sequence = "Yes";
                if (numbers[cnt] > numbers[cnt + 1])
                {
                    sequence = "No";
                    break;
                }
            }
            Console.WriteLine(sequence);
        }
    }
}
