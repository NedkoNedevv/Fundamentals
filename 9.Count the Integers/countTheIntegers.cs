using System;


namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                var n = 0;
                try
                {
                    n = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    break;

                }
            }
            Console.WriteLine(counter);
        }
    }
}