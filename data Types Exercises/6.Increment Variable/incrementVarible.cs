using System;


namespace _6.Increment_Variable
{
    class incrementVarible
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int overflow = num / 256;
            int result = num % 256;

            Console.WriteLine(result);
            if (overflow >= 1)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }
        }
    }
}
