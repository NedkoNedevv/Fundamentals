using System;


namespace _10.Multiplication_table_2._0
{
    class multiplicationTable2
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {times} = {num * times}");
                times++;
            } while (times <= 10);
        }
    }
}
