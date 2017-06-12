using System;


namespace _14.ASCII_String
{
    class ascii
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var characters = int.Parse(Console.ReadLine());

                result += (char)characters;
            }
            Console.WriteLine(result);
        }
    }
}
