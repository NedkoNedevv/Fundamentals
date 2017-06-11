using System;


namespace _11.Odd_Number
{
    class oddNumber
    {
        static void Main()
        {
            int num = 1;

            while (true)
            {
                num = Math.Abs(int.Parse(Console.ReadLine()));
                if (num % 2 == 1)
                {
                    break;
                    //Console.WriteLine($"The number is: {num}");
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
            Console.WriteLine("The number is: " + num);
        }
    }
}
