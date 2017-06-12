using System;


namespace _6.Triples_of_Latin_Letters
{
    class triplesOfLatinLetters
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (char cnt1 = 'a'; cnt1 < 'a' + input; cnt1++)
            {
                for (char cnt2 = 'a'; cnt2 < 'a'+ input; cnt2++)
                {
                    for (char cnt3 = 'a'; cnt3 < 'a' + input; cnt3++)
                    {
                        Console.WriteLine("" + cnt1 + cnt2 + cnt3);
                    }
                }
            }
        }
    }
}
