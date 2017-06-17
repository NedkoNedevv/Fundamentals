using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Repeater
{
    class stringRepeatur
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str, count));
        }
        static string RepeatString(string str, int count)
        {
            string repeatedSring = String.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedSring += str;
            }
            return repeatedSring;
        }
    }
}
