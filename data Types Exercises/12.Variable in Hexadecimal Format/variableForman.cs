using System;


namespace _12.Variable_in_Hexadecimal_Format
{
    class variableForman
    {
        static void Main()
        {
            var number = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(number, 16));
        }
    }
}
