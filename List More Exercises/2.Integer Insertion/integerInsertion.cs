using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_Insertion
{
    class integerInsertion
    {
        static void Main(string[] args)
        {
            List<int> element = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                int currentNum = int.Parse(input);
                int firstDigit = input[0] - '0';

                element.Insert(firstDigit, currentNum);

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", element));
        }
    }
}
