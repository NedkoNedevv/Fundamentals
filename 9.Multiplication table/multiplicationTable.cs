using System;


namespace _9.Multiplication_table
{
    class multiplicationTable
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            //var count = 1;
            //while (count <= 10)
            //{
            //    Console.WriteLine($"{num} X {count} = {num * count}");
            //    count++;
            //}
        }
    }
}
