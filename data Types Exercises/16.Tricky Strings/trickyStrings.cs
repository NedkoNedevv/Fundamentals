using System;
using System.Collections.Generic;


namespace _16.Tricky_Strings
{
    class trickyStrings
    {
        static void Main()
        {

            string separator = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            var stringList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string words = Console.ReadLine();
                stringList.Add(words);
            }

            Console.WriteLine(string.Join(separator, stringList));
        }
    }
}

