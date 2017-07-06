using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_Character_Delimiter
{
    class AverageCharger
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            double totalSum = 0;
            double cntCharacters = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i];
                cntCharacters += word.Length;
                for (int j = 0; j < elements[i].Length; j++)
                {
                    totalSum += word[j];
                }

            }
            char charDelimeter = (char)((int)(totalSum / cntCharacters));
            string delimeter = charDelimeter.ToString().ToUpper();
            Console.WriteLine(string.Join(delimeter, elements));
        }
    }
}
