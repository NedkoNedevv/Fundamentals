using System;


namespace EXE
{
    class exe
    {
        static void Main()
        {


            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (times <= 10)
                {
                    Console.WriteLine($"{num} X {times} = {num * times}");
                                       
                }
                 else if (times > 10)
                {
                    Console.WriteLine($"{num} X {times} = {num * times}");
                }
            }
        }
    }
}

