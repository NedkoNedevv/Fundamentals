using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class debugingExe
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;


            for (int i = 1; i <= numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();

                if (i == numberOfStrings)
                {
                    result += currentString;
                }
                else
                {
                    result += currentString + delimiter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
