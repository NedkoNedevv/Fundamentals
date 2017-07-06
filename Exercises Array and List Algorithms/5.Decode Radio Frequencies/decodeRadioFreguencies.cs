
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
            string[] freguenciesInput = Console.ReadLine().Split(' ');
            List<char> endMesage = new List<char>();



            for (int i = 0; i < freguenciesInput.Length; i++)
            {
                string[] tokens = freguenciesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstFreq != 0)
                {
                    endMesage.Insert(i, firstLetter);
                }
                if (secondFreq != 0)
                {
                    endMesage.Insert(endMesage.Count - 1 - i, secondLetter);
                }
            }
            endMesage.Reverse();
            Console.WriteLine(string.Join("", endMesage));
        }
    }
}




