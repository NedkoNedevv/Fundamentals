using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class splitByWord
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                      .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                      StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].All(char.IsLower))
                {
                    lowerCase.Add(words[i]);
                }
                else if (words[i].All(char.IsUpper))
                {
                    upperCase.Add(words[i]);
                }
                else
                {
                    mixedCase.Add(words[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
