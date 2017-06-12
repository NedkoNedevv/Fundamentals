using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace task10_Data_overflow

{

    class Program

    {

        static void Main(string[] args)

        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            decimal minNum = Math.Min(num1, num2);
            decimal maxNum = Math.Max(num1, num2);

            decimal overflowValue = 0;

            string smallerType = string.Empty;
            if (minNum <= byte.MaxValue)

            {
                overflowValue = byte.MaxValue;
                smallerType = "byte";
            }
            else if (minNum <= ushort.MaxValue)
            {
                overflowValue = ushort.MaxValue;
                smallerType = "ushort";
            }
            else if (minNum <= uint.MaxValue)
            {
                overflowValue = uint.MaxValue;
                smallerType = "uint";
            }
            else if (minNum <= ulong.MaxValue)

            {
                overflowValue = ulong.MaxValue;
                smallerType = "ulong";
            }

            string maxType = string.Empty;
            if (maxNum <= byte.MaxValue)
            {
                maxType = "byte";
            }
            else if (maxNum <= ushort.MaxValue)
            {
                maxType = "ushort";
            }
            else if (maxNum <= uint.MaxValue)

            {
                maxType = "uint";
            }
            else if (maxNum <= ulong.MaxValue)
            {
                maxType = "ulong";
            }
            decimal overflowCount = Math.Round(maxNum / overflowValue);

            Console.WriteLine($"bigger type: {maxType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{maxNum} can overflow {smallerType} {Math.Ceiling(overflowCount)} times");
        }
    }
}