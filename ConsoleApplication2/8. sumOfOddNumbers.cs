using System;


namespace SumOfOddNumbers
{
    class sumOfOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            int count = 0;
            int sum = 0;

            for (int i = 1; ; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                    sum += i;
                    Console.WriteLine(i);
                }
                if (count == n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
