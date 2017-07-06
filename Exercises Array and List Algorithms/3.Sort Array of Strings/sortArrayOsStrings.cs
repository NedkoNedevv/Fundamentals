using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sort_Array_of_Strings
{
    class sortArrayOfStrings
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();

            double totalSum = 0;
            double CntCharacters = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i];
                CntCharacters += word.Length;

                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];
                }
            }
            char charDelimeter = (char)((int)(totalSum / CntCharacters));
            string delimeter = charDelimeter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimeter, elements));

        }
    }
}
