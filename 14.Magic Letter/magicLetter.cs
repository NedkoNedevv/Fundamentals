using System;


namespace _14.Magic_Letter
{
    class magicLetter
    {
        static void Main()
        {
            var first = char.Parse(Console.ReadLine());
            var last = char.Parse(Console.ReadLine());
            var magic = char.Parse(Console.ReadLine());

            var cnt = 0;

            for (char i = first; i <= last; i++)
            {
                for (char j = first; j < last; j++)
                {
                    for (char k = first; k < last; k++)
                    {
                        string word = "" + i + j + k;
                        if (i != magic && j != magic && k != magic)
                        {
                            Console.Write(($"{i}{j}{k} "));
                            cnt++;
                        }
                    }
                }
            }          
        }
    }
}
