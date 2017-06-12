using System;


namespace _7.From_Terabytes_to_Bits
{
    class terabytesToBits
    {
        static void Main()
        {
           double teraBytes = double.Parse(Console.ReadLine());

            decimal oneBite = (decimal)1024 * 1024 * 1024 * 1024 * 8;

            var result = oneBite * (decimal)teraBytes;

            Console.WriteLine($"{result:f0}");
        }
    }
}
