using System;


namespace _12.Number_Checker
{
    class numberCheker
    {
        static void Main()
        {
            int num = 0;

            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

