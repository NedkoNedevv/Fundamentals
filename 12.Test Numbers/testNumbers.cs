using System;


namespace task12TestNums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            var combCounter = 0;
            var result = 0.0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (result >= boundary)
                    {
                        break;
                    }
                    result += (i * j) * 3;
                    combCounter++;
                }
            }
            if (result >= boundary)
            {
                Console.WriteLine($"{combCounter} combinations");
                Console.WriteLine($"Sum: {result} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combCounter} combinations");
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}