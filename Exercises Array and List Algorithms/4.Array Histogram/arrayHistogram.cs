using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE
{
    class exe
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            List<string> foundwords = new List<string>();
            List<int> countWords = new List<int>();


            for (int i = 0; i < words.Length; i++)
            {
                string currenInput = words[i];
                if (foundwords.Contains(currenInput))
                {
                    int wordIndex = foundwords.IndexOf(currenInput);
                    countWords[wordIndex]++;
                }
                else
                {
                    foundwords.Add(currenInput);
                    countWords.Add(1);
                }
            }
            // countWords.Sort();
            // countWords.Reverse();
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < countWords.Count - 1; i++)
                {
                    if (countWords[i] < countWords[i + 1])
                    {
                        int temp = countWords[i];
                        countWords[i] = countWords[i + 1];
                        countWords[i + 1] = temp;

                        string tempWord = foundwords[i];
                        foundwords[i] = foundwords[i + 1];
                        foundwords[i + 1] = tempWord;
                    }
                }
            }
            for (int i = 0; i < foundwords.Count; i++)
            {
                double percent = (countWords[i] * 100.0) / words.Length;

                Console.WriteLine("{0} -> {1} times ({2}%)", foundwords[i],
                    countWords[i], percent);
            }
        }
    }
}
