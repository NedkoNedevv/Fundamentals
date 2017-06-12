using System;


namespace _3.Exact_Product_of_Real_Numbers
{
    class exactProductOfRealNumber
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 1;

            for (int i = 0; i < numbers; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum *= currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
