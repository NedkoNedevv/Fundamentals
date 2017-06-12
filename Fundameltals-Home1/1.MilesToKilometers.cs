using System;


namespace Fundameltals_Home1
{
    class MilesToKilometers
    {
        static void Main()
        {
            double inputMile = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", inputMile * 1.60934);
        }
    }
}
